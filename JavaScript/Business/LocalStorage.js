export function store(data) { localStorage.setItem("data", data); } 

export function show() { return localStorage.getItem("data"); }