document.addEventListener('DOMContentLoaded', function() {
    // Ürün görselleri için event listener'lar
    const mainImage = document.querySelector('.main-image img');
    const thumbnails = document.querySelectorAll('.thumbnail img');
    
    thumbnails.forEach(thumbnail => {
        thumbnail.addEventListener('click', function() {
            mainImage.src = this.src;
            
            thumbnails.forEach(thumb => thumb.parentElement.classList.remove('active'));
            this.parentElement.classList.add('active');
        });
    });
    
    // Miktar seçimi için değişkenler
    const quantityInput = document.getElementById('quantity');
    const decreaseBtn = document.getElementById('decreaseQuantity');
    const increaseBtn = document.getElementById('increaseQuantity');
    
    // Miktar seçimi işlemleri
    if (quantityInput && decreaseBtn && increaseBtn) {
        // Miktar azaltma
        decreaseBtn.addEventListener('click', function() {
            const currentValue = parseInt(quantityInput.value);
            const minValue = parseInt(quantityInput.getAttribute('min'));
            
            if (currentValue > minValue) {
                quantityInput.value = currentValue - 1;
            }
        });
        
        // Miktar artırma
        increaseBtn.addEventListener('click', function() {
            const currentValue = parseInt(quantityInput.value);
            const maxValue = parseInt(quantityInput.getAttribute('max'));
            
            if (currentValue < maxValue) {
                quantityInput.value = currentValue + 1;
            }
        });
        
        // Input değerini kontrol et
        quantityInput.addEventListener('input', function() {
            const currentValue = parseInt(this.value);
            const minValue = parseInt(this.getAttribute('min'));
            const maxValue = parseInt(this.getAttribute('max'));
            
            if (isNaN(currentValue) || currentValue < minValue) {
                this.value = minValue;
            } else if (currentValue > maxValue) {
                this.value = maxValue;
            }
        });
        
        // Klavye ok tuşlarını engelle
        quantityInput.addEventListener('keydown', function(e) {
            if (e.key === 'ArrowUp' || e.key === 'ArrowDown') {
                e.preventDefault();
            }
        });
    }

    // Sepete ekleme işlemi
    const addToCartBtn = document.getElementById('addToCartBtn');
    if (addToCartBtn) {
        addToCartBtn.addEventListener('click', function() {
            const productId = this.getAttribute('data-product-id');
            const quantity = parseInt(quantityInput.value);
            const color = document.querySelector('input[name="colorOption"]:checked')?.value;

            fetch('/Cart/AddToCart', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify({
                    productId: productId,
                    quantity: quantity,
                    color: color
                })
            })
            .then(response => response.json())
            .then(data => {
                if (data.success) {
                    alert(data.message);
                    document.dispatchEvent(new Event('cartUpdated'));
                } else {
                    alert(data.message);
                    if (data.redirect) {
                        window.location.href = data.redirect;
                    }
                }
            })
            .catch(error => {
                console.error('Error:', error);
                alert('Bir hata oluştu. Lütfen tekrar deneyin.');
            });
        });
    }
}); 