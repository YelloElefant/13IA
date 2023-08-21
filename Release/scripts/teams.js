console.log("js loaded")

let previousOpenedCard = null;

function openCard(ele) {
    let content = ele.previousSibling.previousSibling;
    console.log(content)

    if (content.style.display == "none") {
        openUpCard(ele);

        if (previousOpenedCard != null) {
            closeCard(previousOpenedCard);
        }
        previousOpenedCard = ele;
        console.log(previousOpenedCard)
        console.log('card opened')



    } else {
        closeCard(ele);
        previousOpenedCard = null;
        console.log('card closed')
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
    card.style.width = "500px";
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
    card.style.width = "400px";
}