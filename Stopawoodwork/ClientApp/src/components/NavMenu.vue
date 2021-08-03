<template>
    <div class="header affix">
        <div class="table">
            <div class="table-cell">
                <!-- Logo -->
                <div class="logo">
                <img src="../assets/logotomo2.png" />
                </div>
                <!-- End Logo -->

                <!-- Navigation -->
                <div class="main-menu">
                    <nav>
                        <ul class="menu-list">
                            <li>
                                <a href="#">Galéria</a>
                            </li>
                            <li>
                                <a href="#">Drevené kúpeľne</a>
                            </li>
                            <li>
                                <a href="#">Kontakt</a>
                            </li>
                        </ul>
                    </nav>
                </div>
                <!-- End Navigation -->

                <!-- Socials -->
                <div class="socials">
                    <a href="#" title="Facebook">
                        <i class="fab fa-facebook"></i>
                    </a>
                    <a href="#" title="Instagram">
                        <i class="fab fa-instagram"></i>
                    </a>
                </div>
                <!-- End Socials -->

                <div class="copyright">
                    <p>
                        STOPAWOODWORK @ 2021
                    </p>
                </div>
            </div>
        </div>
    </div>  
</template>

<style scoped>
.main-menu,
  .menu-left .main-menu {
    max-height: 45%;
    overflow-y: auto;
    overflow-x: hidden;
    padding-right: 50px;
  }
  .main-menu a:hover,
  .menu-left .main-menu a:hover {
    color: #ffffff !important;
  }
  .main-menu .active a,
  .menu-left .main-menu .active a {
    color: #ffffff;
  }
  .main-menu .sub-menu,
  .menu-left .main-menu .sub-menu {
    display: none;
    position: relative;
    width: 100%;
    left: 0;
    visibility: visible;
    opacity: 1;
    padding-left: 0;
    text-align: center;
  }
  .main-menu .sub-menu li,
  .menu-left .main-menu .sub-menu li,
  .main-menu .sub-menu li:first-child,
  .menu-left .main-menu .sub-menu li:first-child,
  .main-menu .sub-menu li:last-child,
  .menu-left .main-menu .sub-menu li:last-child {
    padding-top: 5px;
    padding-bottom: 5px;
  }
</style>
<script>
    export default {
        name: "NavMenu"
    }
</script>