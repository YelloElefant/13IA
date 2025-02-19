console.log("index.js loaded");

let currentPath = window.location.pathname;
currentPath = currentPath.split("/");


currentPath = currentPath[currentPath.length - 1];
if (currentPath == "index.html" || currentPath == "" || currentPath == "index" || currentPath == "/") {
  currentPath = "index"
} else {

  currentPath = currentPath.split(".")[0];
}


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

function showOpenMore() {

  const size = 5

  function drawCircle(radius, semi) {
    const thickness = 0.4;
    const symbol = '*';
    const rin = radius - thickness
    const rout = radius + thickness;

    if (semi) {
      yNum = 2
    } else {
      yNum = radius
    }

    for (let y = yNum; y >= -radius; --y) {
      let string = '';
      for (let x = -radius; x < rout; x += 0.5) {
        const value = x * x + y * y;
        if (value >= rin * rin && value <= rout * rout) {
          string += symbol;
        } else {
          string += " ";
        }
      }
      if (semi) {
        console.log("        " + string);
        continue;
      }
      console.log(string + string);
    }
  }
  drawCircle(size, false);

  let string = "\t\t **\t\t\t\t        **\n"
  let outputString = string;
  for (let i = 0; i < 20; i++) {
    outputString += string
  }
  console.log(outputString);

  console.log("\t\t -------------------------")


  drawCircle(size * 1.25, true)
}