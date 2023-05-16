const http = require('http');
const fs = require('fs');
const path = require('path');

const server = http.createServer((req, res) => {
    const filePath = path.join(__dirname, req.url);
    const fileExt = path.extname(filePath);
    let contentType = 'text/html';

    if (fileExt === '.js') {
        contentType = 'text/javascript';
    }

    fs.readFile(filePath, (err, content) => {
        if (err) {
            res.writeHead(404, { 'Content-Type': 'text/plain' });
            res.end('File not found');
        } else {
            res.writeHead(200, {
                'Content-Type': contentType,
                'Server': 'Login & Register server'
            });
        res.end(content);
        }
    });
});

server.listen(3000, () => {
    console.log('Server is running on port 3000');
});
