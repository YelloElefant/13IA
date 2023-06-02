console.log("js loaded");



function openTab(ele) {
   if (ele.id.includes("open")) {
      for (var i = 0; i < ele.children.length; i++) {
         ele.children[i].style.display = "none";
      }
      ele.id = ele.id.replace("open", "close");
      return;
   }
   
   if (ele.id.includes("close")) {
      for (var i = 0; i < ele.children.length; i++) {
         ele.children[i].style.display = "block";
      }
      ele.id = ele.id.replace("close", "open");
   }


}