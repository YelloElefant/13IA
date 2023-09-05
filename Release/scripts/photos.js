console.log("photos.js loaded")

let img = new Image()
img.src = "./Images/sponserPlaceHolder.png"

let photos = document.getElementById("photos")

photos.children.push(img)