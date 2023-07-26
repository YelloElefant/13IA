console.log("js loaded")

function showMore(ele) {
    let content = ele.previousSibling.previousSibling;
    console.log(content)
    if (content.style.display == "none") {
        content.style.display = "block"
        ele.style.transform = "rotate(180deg)";

    }
    else {
        content.style.display = "none"
        ele.style.transform = "rotate(0deg)";

    }


}