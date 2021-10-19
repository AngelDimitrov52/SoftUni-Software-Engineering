function editElement(ref , match , replacer) {
    const content = ref.textContent;
    const macher = new RegExp(match , 'g');
    const editer = content.replace(macher , replacer)
    ref.textContent = editer;
}