function attachEvents() {
    let submitWeatherButton = document.getElementById('submit');
    submitWeatherButton.addEventListener('click', showWeather);
    let locationInput = document.getElementById('location');

    let conditions = {
        Sunny: () => '☀',
        "Partly sunny": () => '⛅',
        Overcast: () => '☁',
        Rain: () => '☂'
    }

    function showWeather(e) {

        let forecastContainer = document.getElementById('forecast');

        let currentForecastContainer = document.querySelector('#current');
        Array.from(currentForecastContainer.querySelectorAll('div')).forEach((element, i) => {
            if (i !== 0) {
                element.remove();
            }
        })
        let upcomingForecastContainer = document.querySelector('#upcoming');
        Array.from(upcomingForecastContainer.querySelectorAll('div')).forEach((element, i) => {
            if (i !== 0) {
                element.remove();
            }
        })

        fetch('http://localhost:3030/jsonstore/forecaster/locations')
            .then(respoce => respoce.json())
            .then(data => {
                let locationName = locationInput.value;
                let currentObject = data.find(x => x.name === locationName);

                let currentPromis =
                    fetch(`http://localhost:3030/jsonstore/forecaster/today/${currentObject.code}`)
                    .then(body => body.json())
                    .then(currentWeatherReport => ({ code: location.code, currentWeatherReport }))
                    .then(({ code, currentWeatherReport }) => {
                        console.log(currentWeatherReport);
                        let htmlReport = createCurrentWeatherElement(currentWeatherReport);
                            currentForecastContainer.appendChild(htmlReport);
                        });

                let nextThreePromis =
                    fetch(`http://localhost:3030/jsonstore/forecaster/upcoming/${currentObject.code}`)
                        .then(respoce => respoce.json())
                        .then(next => {
                            let upcomingForecast = createUpcomingWeatherElement(next);
                            upcomingForecastContainer.appendChild(upcomingForecast);
                        });

                Promise.all([currentPromis, nextThreePromis])
                    .then(x => { forecastContainer.style.display = 'block'; });

            })
            .catch(err => {
                let errorDiv = document.createElement('div');
                errorDiv.classList.add('label');
                errorDiv.textContent = 'Error';
                currentForecastContainer.appendChild(errorDiv);
            });
    }

    function createUpcomingWeatherElement(weatherReport) {
        let forecastInfoDiv = document.createElement('div');
        forecastInfoDiv.classList.add('forecast-info');

        let day1html = createDayReport(weatherReport.forecast[0]);
        let day2html = createDayReport(weatherReport.forecast[1]);
        let day3html = createDayReport(weatherReport.forecast[2]);

        forecastInfoDiv.appendChild(day1html);
        forecastInfoDiv.appendChild(day2html);
        forecastInfoDiv.appendChild(day3html);
        return forecastInfoDiv;
    }

    function createDayReport(forecast) {
        let upcomingSpan = document.createElement('span');
        upcomingSpan.classList.add('upcoming');

        let symbolSpan = document.createElement('span');
        symbolSpan.classList.add('symbol');
        symbolSpan.textContent = conditions[forecast.condition]();

        let tempSpan = document.createElement('span');
        tempSpan.classList.add('forecast-data');
        tempSpan.textContent = `${forecast.low}°/${forecast.high}°`;

        let weatherSpan = document.createElement('span');
        weatherSpan.classList.add('forecast-data');
        weatherSpan.textContent = forecast.condition;

        upcomingSpan.appendChild(symbolSpan);
        upcomingSpan.appendChild(tempSpan);
        upcomingSpan.appendChild(weatherSpan);
        return upcomingSpan;
    }

    function createCurrentWeatherElement(weatherReport) {
        let forecastsDiv = document.createElement('div');
        forecastsDiv.classList.add('forecasts');

        let conditionSymbolSpan = document.createElement('span');
        conditionSymbolSpan.classList.add('condition', 'symbol');
        conditionSymbolSpan.textContent = conditions[weatherReport.forecast.condition]();

        let conditionSpan = document.createElement('span');
        conditionSpan.classList.add('condition');

        let nameSpan = document.createElement('span');
        nameSpan.classList.add('forecast-data');
        nameSpan.textContent = weatherReport.name;

        let tempSpan = document.createElement('span');
        tempSpan.classList.add('forecast-data');
        tempSpan.textContent = `${weatherReport.forecast.low}°/${weatherReport.forecast.high}°`;

        let weatherSpan = document.createElement('span');
        weatherSpan.classList.add('forecast-data');
        weatherSpan.textContent = weatherReport.forecast.condition;

        conditionSpan.appendChild(nameSpan);
        conditionSpan.appendChild(tempSpan);
        conditionSpan.appendChild(weatherSpan);

        forecastsDiv.appendChild(conditionSymbolSpan);
        forecastsDiv.appendChild(conditionSpan);
        return forecastsDiv;
    }
}

attachEvents();