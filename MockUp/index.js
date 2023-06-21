console.log("index.js loaded");



let activeDay = document.getElementById("activeDay");


activeDay.style.borderBottom = "solid black";
activeDay.style.color = "var(--color-gold)";
document.getElementById('Monday').style.display = "table";


function setActive(ele, evt, dayName) {
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





   var i, tabcontent, tablinks;
   tabcontent = document.getElementsByClassName("tabContent");
   for (i = 0; i < tabcontent.length; i++) {
      tabcontent[i].style.display = "none";
   }
   tablinks = document.getElementsByClassName("tabLinks");
   for (i = 0; i < tablinks.length; i++) {
      tablinks[i].className = tablinks[i].className.replace(" active", "");
   }
   document.getElementById(dayName).style.display = "table";
   evt.currentTarget.className += " active";

}