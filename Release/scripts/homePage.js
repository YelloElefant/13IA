console.log("homePage.js loaded")
let headMasterHiddenContent = document.getElementById("hiddenContent");
headMasterHiddenContent.style.display = "none";


function showMore(ele) {
   let x = ele.previousSibling.previousSibling;
   if (x.style.display == "block") {
      x.style.display = "none";
      ele.innerHTML = "Show More";

   } else {
      x.style.display = "block";
      ele.innerHTML = "Show Less";
   }
}