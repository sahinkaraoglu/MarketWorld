document.addEventListener('DOMContentLoaded', function() {
    const mainImage = document.querySelector('.main-image img');
    const thumbnails = document.querySelectorAll('.thumbnail img');
    
    thumbnails.forEach(thumbnail => {
        thumbnail.addEventListener('click', function() {
            mainImage.src = this.src;
            
            thumbnails.forEach(thumb => thumb.parentElement.classList.remove('active'));
            this.parentElement.classList.add('active');
        });
    });
}); 