export function GetQuery(url) {
    return fetch(url)
    .then((response) => response.json())
}

export function SetQuery(url, data) {
    fetch(url, {
        method: 'POST',
        body: JSON.stringify(data),
        headers: {
            'Content-Type': 'application/json',
        },
    }).then((result) => {
        console.log('Success:', result) });
}