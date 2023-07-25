console.log("js loaded")

function showMore(ele) {
    let content = ele.nextElementSibling;
    if (content.style.display == "none") { content.style.display = "block" }
    else { content.style.display = "none" }
}