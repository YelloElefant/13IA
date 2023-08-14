console.log("maps.js loaded");

let placesMap = new Map();

placesMap.set("hbhs", "Hamilton%20Boys%20High%20School");
placesMap.set("marist", "Marist%20Park");
placesMap.set("steel", "Steel%20Park");
placesMap.set("uni", "University%20of%20Waikato")
placesMap.set("cambridge", "Cambridge%20High%20School");
placesMap.set("hautapu", "Hautapu%20Sports%20Club");
placesMap.set("don", "Don%20Llewellyn%20Sports%20Pavillion")
placesMap.set("pa", "waikato%20uni%20pa")

//https://www.google.com/maps/embed/v1/place?q=Marist%20Park&key=AIzaSyA_tMXSrrQSrdKlEB7P3_Wo8U9fq0Htn3A

let activePlace = document.getElementById("activePlace");
activePlace.style.borderRight = "solid black";
activePlace.style.color = "var(--color-gold)";
//document.getElementById('activeDay').style.display = "table";


function setActivePlace(ele, evt, dayName) {
   //removing the active day
   activePlace = document.getElementById("activePlace");
   activePlace.style.border = "solid white thin";
   activePlace.style.borderRight = "solid white";
   activePlace.style.color = "black";
   activePlace.id = "";

   ele.id = "activePlace";

   ele.style.transition = "border-color 0.5s ease-in-out";
   ele.style.borderRight = "solid black";
   ele.style.color = "var(--color-gold)";

   let mapIframe = document.getElementById("mapIframe")
   mapIframe.src = "https://www.google.com/maps/embed/v1/place?q=" + placesMap.get(dayName) + "&key=AIzaSyA_tMXSrrQSrdKlEB7P3_Wo8U9fq0Htn3A";

}