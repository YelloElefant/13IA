console.log("index.js loaded");

let currentPath = window.location.pathname;
currentPath = currentPath.split("/");
if (currentPath == "index.html" || currentPath == "" || currentPath == "index" || currentPath == "/") {
  currentPath = "Home"
}

currentPath = currentPath[currentPath.length - 1].split(".")[0];


let navToHighlight = document.getElementById(currentPath);
navToHighlight = navToHighlight.children[0].children[0];
navToHighlight.style.color = "var(--color-gold)";


let activeDay = document.getElementById("activeDay");


activeDay.style.borderBottom = "solid black";
activeDay.style.color = "var(--color-gold)";
document.getElementById('mondayAM').style.display = "table";


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



function showMore(ele) {
  let x = document.getElementById("showMore");
  if (x.style.display == "block") {
    console.log("showing less");
    x.style.display = "none";
    ele.innerHTML = "Show More";

  } else {
    console.log("showing more");
    x.style.display = "block";
    ele.innerHTML = "Show Less";
  }
}