function solve() {
   let allButtons = document.querySelectorAll('.add-product');
   let textArea = document.getElementsByTagName('textarea')[0];

   let chechOutButton = document.getElementsByClassName('checkout')[0];
   let totalSum = 0;
   let productNames = new Set();

   Array.from(allButtons).forEach(element => {

      element.addEventListener('click', (e) => {
         let name = e.target.parentElement.parentElement
            .getElementsByClassName('product-title')[0].textContent;
         let money = e.target.parentElement.parentElement
            .getElementsByClassName('product-line-price')[0].textContent;
         money = Number(money).toFixed(2);

         totalSum += Number(money);
         productNames.add(name);
         textArea.textContent += `Added ${name} for ${money} to the cart.\n`
      })
   });

   chechOutButton.addEventListener('click', (e) => {
      let produtsArr = Array.from(productNames);
      textArea.textContent += `You bought ${produtsArr.join(', ')} for ${totalSum.toFixed(2)}.`

      document.getElementsByClassName('checkout')[0].disabled = true;
      Array.from(allButtons).forEach(element => {
         element.disabled = true;
      })
   });
}