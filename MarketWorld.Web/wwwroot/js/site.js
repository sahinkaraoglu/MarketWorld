
document.addEventListener('DOMContentLoaded', function() {
    var dropdownElementList = [].slice.call(document.querySelectorAll('.dropdown-toggle'));
    dropdownElementList.map(function(dropdownToggle) {
        dropdownToggle.addEventListener('click', function(e) {
            if (window.innerWidth < 992) {
                e.preventDefault();
                e.stopPropagation();
                var dropdownMenu = this.nextElementSibling;
                if (dropdownMenu) {
                    dropdownMenu.classList.toggle('show');
                }
            }
        });
    });

    var dropdownSubmenus = document.querySelectorAll('.dropdown-submenu');
    dropdownSubmenus.forEach(function(submenu) {
        submenu.addEventListener('mouseenter', function(e) {
            if (window.innerWidth >= 992) {
                var dropdown = this.querySelector('.dropdown-menu');
                if (dropdown) {
                    dropdown.style.display = 'block';
                }
            }
        });

        submenu.addEventListener('mouseleave', function(e) {
            if (window.innerWidth >= 992) {
                var dropdown = this.querySelector('.dropdown-menu');
                if (dropdown) {
                    var rect = dropdown.getBoundingClientRect();
                    if (e.clientX < rect.left || e.clientX > rect.right || 
                        e.clientY < rect.top || e.clientY > rect.bottom) {
                        dropdown.style.display = 'none';
                    }
                }
            }
        });
    });
});
