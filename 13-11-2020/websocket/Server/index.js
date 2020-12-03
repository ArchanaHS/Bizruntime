const websocket=require("ws");
const wss= new websocket.Server({port:8080})

console.log("Working");
wss.on("connection",ws=>{
    console.log("new client connected!....");

    ws.on("message",data=>{
        console.log("client has sent us :${data}");
        ws.send(data.toUpperCase());

    });

    ws.on("close",ws=>{
        console.log("client has disconnecte");
    });
    ws.addEventListener("message",({data})=>{
        console.log(data);
    });
});