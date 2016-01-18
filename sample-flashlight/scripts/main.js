var toggleFLButton;
var msg;

document.addEventListener("deviceready", onDeviceReady, false);

function onDeviceReady() {
    navigator.splashscreen.hide();
    toggleFLButton = document.getElementById("buttonToggleFL");
    toggleFLButton.addEventListener("click", toggleFlashLight);
}

function toggleFlashLight() {
    if (window.navigator.simulator === true) {
        alert("Not Supported in Simulator.");
    }
    else {
        window.plugins.flashlight.available(function(isAvailable) {
            if (isAvailable) {
                // toggle on/off
                if (toggleFLButton.textContent === "Turn ON aFlash") {
                    toggleFLButton.textContent = "Turn OFF aFlash";
                }
                else {
                    toggleFLButton.textContent = "Turn ON aFlash";
                } 
                window.plugins.flashlight.toggle(onSuccess, onError);
            }
            else {
                alert("aFlash not available on this device");
            }
        });
    }
}

function onSuccess() {
    msg = "Device flashlight has been toggled successfully!";
    showMessage(msg);
}
    
function onError() {
    msg = "Something went wrong. aFlash could not be turned on";
    showMessage(msg);
}
    
function showMessage(text) {
    var statusBox = document.getElementById('result');
    statusBox.textContent = text;
}
