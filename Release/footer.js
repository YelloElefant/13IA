console.log("footer loading...")
fetchStuff()

async function fetchStuff() {
    const response = await fetch("https://118.95.173.58/9atrotte/13IA/Release/footer.html", {
        mode: 'no-cors',
        method: "get",
        headers: {
            "Content-Type": "text/html"
        },
    })
    console.log(response);
}