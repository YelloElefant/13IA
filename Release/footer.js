console.log("footer loading...")
fetchStuff()

async function fetchStuff() {
    const response = await fetch("http://localhost/9atrotte/13IA/Release/footer.html", {
        mode: 'no-cors',
        method: "get",
        headers: {
            "Content-Type": "text/html"
        },
    })
    console.log(response);
}