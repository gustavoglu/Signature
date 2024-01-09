let codeBar = null;

function onScanSuccess(decodedText, decodedResult) {
    // handle the scanned code as you like, for example:
    console.log(`Code matched = ${decodedText}`, decodedResult);
    codeBar = decodedText;
    console.log("codeBar " + codeBar);
}
function onScanFailure(error) {}

let html5QrcodeScanner = new Html5QrcodeScanner(
    "videoFeed",
    { fps: 10, qrbox: { width: 250, height: 250 } },
  /* verbose= */ false);
html5QrcodeScanner.render(onScanSuccess, onScanFailure);


export function getCodeBar() { return codeBar; }
