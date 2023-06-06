console.log("js loaded");



function openTab(ele) {
   if (ele.id.includes("open")) {
      for (var i = 0; i < ele.children.length; i++) {
         ele.children[i].style.display = "none";
         ele.children[i].style.opacity = "0";
         // ele.style.backgroundColor = "aqua";
      }
      ele.id = ele.id.replace("open", "close");
      return;
   }

   if (ele.id.includes("close")) {
      for (var i = 0; i < ele.children.length; i++) {
         ele.children[i].style.display = "block";
         ele.children[i].style.opacity = "1";
         // ele.style.backgroundColor = "grey";
      }
      ele.id = ele.id.replace("close", "open");
   }


}