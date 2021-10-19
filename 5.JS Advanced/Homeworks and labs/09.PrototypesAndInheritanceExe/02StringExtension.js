(function solve() {
    let el = '...';

    String.prototype.ensureStart = function (str) {
        if (!this.includes(str)) {
            str = str + this;
        } else {
            str = this;
        }
        return str;
    }
    String.prototype.ensureEnd = function (str) {
        if (!this.includes(str)) {
            str = this + str;
        } else {
            str = this;
        }
        return str;
    }
    String.prototype.isEmpty = function () {
        if (this === '') {
            return true;
        } else {
            return false;
        }
    }
    String.prototype.truncate = function (n) {
        if (n < 4) {
            str = '';
            for (let i = 0; i < n; i++) {
                str += '.';
            }
            return str;
        } else if (!str.includes(' ')) {
            let length = n - 3;
            str = str.slice(0, length);
            str = str + el;
            return str;
        } else if (this.length < n) {
            return this;
        } else {
            str = this + el;
            str = this.split(' ');
            str.pop();
            str = str.join(' ');
            str = str + el;
            return str;
        }
    }

    String.format = function (string, ...params) {
        let pattern = /{[0-9]+}/gm;
        let splitted = string.split(' ');
        for (let i = 0; i < splitted.length; i++) {
            let current = splitted[i];
            let test = current.match(pattern);
            if (test !== null) {
                for (let k = 0; k < params.length; k++) {
                    current = params[k];
                    splitted = splitted.toString().replace(splitted[i], current).split(',');
                    params.shift();
                    break;
                }
            }
        }
        str = splitted.join(' ')
        return str;
    }
})()