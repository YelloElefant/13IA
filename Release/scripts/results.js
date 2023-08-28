console.log("results loaded")

let tabContent = document.getElementsByClassName("tabContent");
console.log(tabContent);

for (let i = 0; i < tabContent.length; i++) {
   const elements = tabContent[i].children[0].children;
   console.log(elements);
   for (let j = 0; j < elements.length; j++) {
      let score1Ele = elements[j].children[2];
      let score2Ele = elements[j].children[4];
      let score1 = Number(elements[j].children[2].innerHTML);
      let score2 = Number(elements[j].children[4].innerHTML);
      if (score1 > score2) {
         console.log(score1Ele.previousSibling.previousSibling);
         score1Ele.previousSibling.previousSibling.style.color = "var(--color-gold)";
         score1Ele.previousSibling.previousSibling.style.fontWeight = "bold";
      } else if (score1 < score2) {
         score2Ele.nextSibling.nextSibling.style.color = "var(--color-gold)";
         score2Ele.nextSibling.nextSibling.style.fontWeight = "bold";
      }
   }
}