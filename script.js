document.getElementById('fetchCat').addEventListener('click', function() {
    // Create a new XMLHttpRequest object
    var xhr = new XMLHttpRequest();

    // Configure it: GET-request for the cat image API
    xhr.open('GET', 'https://rory.cat/purr', true);

    // Set up a function to handle the response
    xhr.onload = function() {
        if (xhr.status >= 200 && xhr.status < 300) {
            // Parse the JSON response
            var data = JSON.parse(xhr.responseText);
            
            // Clear previous output
            var outputDiv = document.getElementById('output');
            outputDiv.innerHTML = '';

            // Create an image element
            var img = document.createElement('img');
            img.src = data.url; // The URL of the cat image
            img.alt = 'Cute Cat'; // Alt text for the image

            // Create a title element
            var title = document.createElement('p');
            title.textContent = `Cat ID: ${data.id}`; // Display the cat ID

            // Append the image and title to the output div
            outputDiv.appendChild(img);
            outputDiv.appendChild(title);
        } else {
            console.error('Request failed with status:', xhr.status);
        }
    };

    // Handle network errors
    xhr.onerror = function() {
        console.error('Request failed');
    };

    // Send the request
    xhr.send();
});