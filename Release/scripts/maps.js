console.log("maps.js loaded");

let placesMap = new Map();

placesMap.set("hbhs", "Hamilton%20Boys%20High%20School");
placesMap.set("marist", "Marist%20Park");
placesMap.set("stAndrews", "te%20rapa%20rugby%20club");
placesMap.set("uni", "University%20of%20Waikato")
placesMap.set("cambridge", "Cambridge%20High%20School");
placesMap.set("hautapu", "Hautapu%20Sports%20Club");
placesMap.set("don", "Don%20Llewellyn%20Sports%20Pavillion")
placesMap.set("pa", "waikato%20uni%20pa")
placesMap.set("hob", "Hamilton%20Old%20Boys%20Rugby%20Netball%20and%20Squash%20Club")

//https://www.google.com/maps/embed/v1/place?q=Marist%20Park&key=AIzaSyA_tMXSrrQSrdKlEB7P3_Wo8U9fq0Htn3A

let activePlace = document.getElementById("activePlace");

if (window.innerWidth <= 790) {
   activePlace.style.borderTop = "solid black";
} else {
   activePlace.style.borderRight = "solid black";
}


activePlace.style.color = "var(--color-gold)";
//document.getElementById('activeDay').style.display = "table";

let foldOutAllowed = false;

function setActivePlace(ele, evt, placeName) {
   if (foldOutAllowed == false && (placeName == "pa" || placeName == "don")) {
      return
   }
   //removing the active day
   activePlace = document.getElementById("activePlace");
   activePlace.style.border = "solid white thin";
   activePlace.style.borderRight = "solid white";

   activePlace.style.color = "black";
   activePlace.id = "";


   ele.id = "activePlace";
   if (placeName == "pa" || placeName == "don") {

      ele.style.transition = "border-color 0.5s ease-in-out";
      ele.style.borderTop = "solid black";
      ele.style.color = "var(--color-gold)";
   } else {
      ele.style.transition = "border-color 0.5s ease-in-out";

      if (window.innerWidth <= 790) {
         ele.style.borderTop = "solid black";
      } else {
         ele.style.borderRight = "solid black";
      }


      ele.style.color = "var(--color-gold)";
   }
   let mapIframe = document.getElementById("mapIframe")
   mapIframe.src = "https://www.google.com/maps/embed/v1/place?q=" + placesMap.get(placeName) + "&key=AIzaSyA_tMXSrrQSrdKlEB7P3_Wo8U9fq0Htn3A";


   if (placeName == "pa" || placeName == "don") {
      return;
   }

   let foldOut = document.getElementById("foldOut");
   let foldOutDivs = foldOut.getElementsByTagName("div");
   if (placeName == "uni") {
      foldOut.style.display = "flex";
      foldOut.style.backgroundColor = "#f2f2f2"
      foldOutDivs[0].style.backgroundColor = "white";
      foldOutDivs[1].style.backgroundColor = "white";
      foldOutDivs[0].style.color = "black";
      foldOutDivs[1].style.color = "black";
      foldOutDivs[0].style.cursor = "pointer";
      foldOutDivs[1].style.cursor = "pointer";
      foldOutAllowed = true;

   } else {
      foldOut.style.color = "transparent";
      foldOut.style.backgroundColor = "transparent";
      foldOutDivs[0].style.backgroundColor = "transparent";
      foldOutDivs[1].style.backgroundColor = "transparent";
      foldOutDivs[0].style.color = "transparent";
      foldOutDivs[1].style.color = "transparent";
      foldOutDivs[0].style.border = "none";
      foldOutDivs[1].style.border = "none";
      foldOutDivs[0].style.cursor = "unset";
      foldOutDivs[1].style.cursor = "unset";
      foldOutAllowed = false;
   }

}