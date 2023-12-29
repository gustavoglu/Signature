const canvas = document.querySelector("canvas");

const signaturePad = new SignaturePad(canvas);

export function clear() {
    // Clears the canvas
    signaturePad.clear();
}

export function isEmpty() {
    // Returns true if canvas is empty, otherwise returns false
    return signaturePad.isEmpty();
}

export function getBase64() {
    return signaturePad.toDataURL("image/jpeg");
}

export function alerta(message) {
    alert(message);
}


