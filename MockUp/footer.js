console.log("footer loading...")

fetch("https://localhost:80/9atrote/13IA/MockUp/footer.html")
    .then(x => x.text())
    .then(y => document.getElementById("footer").innerHTML = y);