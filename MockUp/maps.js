console.log("index.js loaded");



let activeDay = document.getElementById("activeDay");


activeDay.style.borderRight = "solid black";
activeDay.style.color = "var(--color-gold)";
document.getElementById('hbhs').style.display = "table";


function setActive(ele, evt, dayName) {
   //removing the active day
   activeDay = document.getElementById("activeDay");
   activeDay.style.border = "solid white thin";
   activeDay.style.borderRight = "solid white";
   activeDay.style.color = "black";
   activeDay.id = "";

   ele.id = "activeDay";

   ele.style.transition = "border-color 0.5s ease-in-out";
   ele.style.borderRight = "solid black";
   ele.style.color = "var(--color-gold)";




}