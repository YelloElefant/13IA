console.log("js loaded")

function showMore(ele) {
    let content = ele.previousSibling.previousSibling;
    let img = content.previousSibling.previousSibling.children[0].children[0];
    console.log(img)
    console.log(content)
    if (content.style.display == "none") {
        content.style.display = "block"
        ele.children[0].children[0].style.transform = "rotate(180deg)";
        img.style.height = "100px";
    } else {
        content.style.display = "none"
        ele.children[0].children[0].style.transform = "rotate(0deg)";
        img.style.height = "100%";

    }


}