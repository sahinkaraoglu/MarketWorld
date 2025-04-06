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

    // Renk ve hafıza seçenekleri için event listener'lar
    document.querySelectorAll('input[name="colorOption"]').forEach(radio => {
        radio.addEventListener('change', function() {
            document.getElementById('selectedColor').textContent = this.value;
            updateProductOptions();
        });
    });

    document.querySelectorAll('input[name="memoryOption"]').forEach(radio => {
        radio.addEventListener('change', function() {
            document.getElementById('selectedMemory').textContent = this.value;
            updateProductOptions();
        });
    });

    function updateProductOptions() {
        const selectedColor = document.querySelector('input[name="colorOption"]:checked')?.value;
        const selectedMemory = document.querySelector('input[name="memoryOption"]:checked')?.value;
        
        if (selectedColor && selectedMemory) {
            // Burada seçilen renk ve hafızaya göre fiyat güncellemesi yapılabilir
            // AJAX ile sunucudan yeni fiyat ve stok bilgisi alınabilir
            console.log(`Seçilen: ${selectedColor} - ${selectedMemory}`);
        }
    }

    // Sayfa yüklendiğinde varsayılan seçimleri göster
    const defaultColor = document.querySelector('input[name="colorOption"]');
    const defaultMemory = document.querySelector('input[name="memoryOption"]');
    
    if (defaultColor) defaultColor.checked = true;
    if (defaultMemory) defaultMemory.checked = true;
    
    updateProductOptions();

    // Sepete ekleme işlemi
    const addToCartBtn = document.getElementById('addToCartBtn');
    if (addToCartBtn) {
        addToCartBtn.addEventListener('click', function() {
            const productId = this.getAttribute('data-product-id');
            const quantity = parseInt(quantityInput.value);
            const color = document.querySelector('input[name="colorOption"]:checked')?.value;

            // FormData oluştur
            const formData = new FormData();
            formData.append('productId', productId);
            formData.append('quantity', quantity);
            if (color) {
                formData.append('color', color);
            }

            fetch('/Cart/AddToCart', {
                method: 'POST',
                body: formData
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