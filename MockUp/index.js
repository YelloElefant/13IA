console.log("index.js loaded");



let activeDay = document.getElementById("activeDay");


activeDay.style.borderBottom = "solid black";
activeDay.style.color = "var(--color-gold)";


function setActive(ele) {
  //removing the active day
  activeDay = document.getElementById("activeDay");
  activeDay.style.border = "solid white thin";
  activeDay.style.borderBottom = "solid white";
  activeDay.style.color = "black";
  activeDay.id = "";

  ele.id = "activeDay";

  ele.style.transition = "border-color 0.5s ease-in-out";
  ele.style.borderBottom = "solid black";
  ele.style.color = "var(--color-gold)";


}
