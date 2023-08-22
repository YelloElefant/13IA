console.log("js loaded")

let previousOpenedCard = null;
let previousWidth = null;


function openCard(ele) {
    let content = ele.previousSibling.previousSibling;
    console.log(content)

    if (content.style.display == "none") {
        previousWidth = ele.parentElement.style.width;
        if (previousOpenedCard != null) {
            closeCard(previousOpenedCard);
        }
        openUpCard(ele);
        previousOpenedCard = ele;



    } else {
        closeCard(ele);
        previousOpenedCard = null;
    }



}

function openUpCard(ele) {
    let content = ele.previousSibling.previousSibling;
    let img = content.previousSibling.previousSibling.children[0].children[0];
    let card = ele.parentElement;
    content.style.display = "block"
    ele.children[0].children[0].style.transform = "rotate(180deg)";
    img.style.height = "100px";
    card.style.height = "auto";
    card.style.width = "100%";
    window.scrollTo(0, card.offsetTop + img.height + 5);

}

function closeCard(ele) {
    let content = ele.previousSibling.previousSibling;
    let img = content.previousSibling.previousSibling.children[0].children[0];
    let card = ele.parentElement;
    content.style.display = "none"
    ele.children[0].children[0].style.transform = "rotate(0deg)";
    img.style.height = "256px";
    img.style.width = "auto";
    card.style.height = "387px";
    card.style.width = previousWidth;
    window.scrollTo(0, card.offsetTop);

}