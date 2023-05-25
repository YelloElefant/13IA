console.log("index.js loaded");



let activeDay = document.getElementById("activeDay");


activeDay.style.border = "solid #f2f2f2 thin";
activeDay.style.borderBottom = "solid black";


function setActive(ele) {
  //removing the active day
  activeDay.style.border = "solid white thin";
  activeDay.style.borderBottom = "solid white";
  activeDay.style.color = "black";
  activeDay.id = "";

  //adding the event listener back to the old active day
  activeDay.addEventListener("mouseover", function( event ) { 
    this.style.color = "var(--color-gold)";
  }, false);

  activeDay.addEventListener("mouseout", function( event ) {
    this.style.color = "black";
  }, false);

  
  
  ele.id = "activeDay";
  activeDay = document.getElementById("activeDay");
  
  //removeing the event listener becuase its the active day
  activeDay.removeEventListener("mouseover", function( event ) {
    this.style.color = "var(--color-gold)";
  }, false);
  activeDay.removeEventListener("mouseout", function( event ) {
    this.style.color = "black";
  }, false);
  


  
    
  activeDay.style.transition = "border-color 0.5s ease-in-out";
  
  activeDay.style.borderBottom = "solid black";
  activeDay.style.borderLeft = "solid #f2f2f2 thin";
  activeDay.style.borderRight = "solid #f2f2f2 thin";
  activeDay.style.borderTop = "solid #f2f2f2 thin";

  activeDay.style.color = "black";


}
