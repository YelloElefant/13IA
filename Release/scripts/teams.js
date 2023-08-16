console.log("js loaded")

function openCard(ele) {
    let content = ele.previousSibling.previousSibling;
    let img = content.previousSibling.previousSibling.children[0].children[0];
    let card = ele.parentElement;
    console.log(img)
    console.log(content)
    if (content.style.display == "none") {
        content.style.display = "block"
        ele.children[0].children[0].style.transform = "rotate(180deg)";
        img.style.height = "100px";
        card.style.height = "auto";

    } else {
        content.style.display = "none"
        ele.children[0].children[0].style.transform = "rotate(0deg)";
        img.style.height = "256px";
        img.style.width = "auto";
        card.style.height = "387px";
        card.style.width = "462.05px";
    }


}