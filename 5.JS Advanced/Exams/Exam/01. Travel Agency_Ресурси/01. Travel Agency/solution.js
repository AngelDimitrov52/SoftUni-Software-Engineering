window.addEventListener('load', solution);

function solution() {
  let submitBotton = document.getElementById('submitBTN');
  submitBotton.addEventListener('click', submitInfo)

  function submitInfo(e) {

    let fullNameElemet = document.getElementById('fname');
    let emailElemet = document.getElementById('email');
    let phoneElemet = document.getElementById('phone');
    let addressElemet = document.getElementById('address');
    let codeElemet = document.getElementById('code');

    if (fullNameElemet.value.trim() == '' || emailElemet.value.trim() == '') {
      return;
    }

    let fullNameLi = document.createElement('li');
    fullNameLi.textContent = `Full Name: ${fullNameElemet.value}`;

    let emailLi = document.createElement('li');
    emailLi.textContent = `Email: ${emailElemet.value}`;

    let phoneLi = document.createElement('li');
    phoneLi.textContent = `Phone Number: ${phoneElemet.value}`;

    let addressLi = document.createElement('li');
    addressLi.textContent = `Address: ${addressElemet.value}`;

    let codeLi = document.createElement('li');
    codeLi.textContent = `Postal Code: ${codeElemet.value}`;

    let nameSave = fullNameElemet.value;
    let emailSave = emailElemet.value;
    let phoneSave = phoneElemet.value;
    let addresSave = addressElemet.value;
    let codeSave = codeElemet.value;

    fullNameElemet.value = '';
    emailElemet.value = '';
    phoneElemet.value = '';
    addressElemet.value = '';
    codeElemet.value = '';

    let button = e.target;
    button.disabled = true;

    let editbutton = document.getElementById('editBTN');
    editbutton.disabled = false;
    editbutton.addEventListener('click', (e) => {

      fullNameElemet.value = nameSave;
      emailElemet.value = emailSave;
      phoneElemet.value = phoneSave;
      addressElemet.value = addresSave;
      codeElemet.value = codeSave;

      editbutton.disabled = true;
      conbutton.disabled = true;
      submitBotton.disabled = false;

      let allLi = Array.from(document.querySelectorAll('#infoPreview li'));
      allLi.forEach(li => {
        li.remove();
      });

    });

    let conbutton = document.getElementById('continueBTN');
    conbutton.disabled = false;
    conbutton.addEventListener('click', efunc)

    let divActionElemet = document.getElementById('infoPreview');
    divActionElemet.appendChild(fullNameLi);
    divActionElemet.appendChild(emailLi);
    divActionElemet.appendChild(phoneLi);
    divActionElemet.appendChild(addressLi);
    divActionElemet.appendChild(codeLi);
  }

  function efunc(e) {

    let h1 = document.querySelector('#block h1');
    let h4 = document.querySelector('#block h4');
    let form = document.querySelector('#form');
    let information = document.querySelector('#information');
    let footer = document.querySelector('footer');

    information.remove();
    form.remove()
    h4.remove();
    h1.remove();
    footer.remove();

    let h3 = document.createElement('h3');
    h3.textContent = "Thank you for your reservation!";

    let blockElemet = document.getElementById('block');
    blockElemet.appendChild(h3);
  };
}
