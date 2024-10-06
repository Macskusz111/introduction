function xhrGet(url) {
    // Create a new XMLHttpRequest object
    const xhr = new XMLHttpRequest();

    // Set up the request
    xhr.open('GET', url, true);
    xhrGet('https://rory.cat/purr');
    // Set up a function to handle the response
    xhr.onload = function () {
        if (xhr.status >= 200 && xhr.status < 300) {
            // Success! Process the response
            const response = JSON.parse(xhr.responseText);
            console.log('Success:', response);
        } else {
            // Handle errors
            console.error('Request failed. Status:', xhr.status);
        }
    };

    // Handle network errors
    xhr.onerror = function () {
        console.error('Network error occurred');
    };

    // Send the request
    xhr.send();
}

// Example usage
//xhrGet('https://rory.cat/purr');
//const obj = JSON.parse(text);
