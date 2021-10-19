function small(array) {

   let firstnum = Math.min(...array);
   let index = array.indexOf(firstnum);

   array.splice(index ,1);
   let second = Math.min(...array);

  console.log(`${firstnum} ${second}`);

}
small([30, 15, 50, 5]);
small([3, 0, 10, 4, 7, 3]);