<!-- header section starts  -->

<header class="header">

   <nav class="navbar nav-1">
      <section class="flex">
         <a href="home.php" class="logo"><i class="fas fa-house"></i>Minha Casinha</a>

         <ul>
            <li><a href="post_property.php">Publicar propriedade<i class="fas fa-paper-plane"></i></a></li>
         </ul>
      </section>
   </nav>

   <nav class="navbar nav-2">
      <section class="flex">
         <div id="menu-btn" class="fas fa-bars"></div>

         <div class="menu">
            <ul>
               <li><a href="#">Minhas listagens<i class="fas fa-angle-down"></i></a>
                  <ul>
                     <li><a href="dashboard.php">Painel</a></li>
                     <li><a href="post_property.php">Publicar Propriedade</a></li>
                     <li><a href="my_listings.php">Minhas Listagens</a></li>
                  </ul>
               </li>
               <li><a href="#">Opções<i class="fas fa-angle-down"></i></a>
                  <ul>
                     <li><a href="search.php">Pesquisa filtrada</a></li>
                     <li><a href="listings.php">Todas as listagens</a></li>
                  </ul>
               </li>
               <li><a href="#">Ajuda<i class="fas fa-angle-down"></i></a>
                  <ul>
                     <li><a href="about.php">Sobre nós</a></i></li>
                     <li><a href="contact.php">Contacta-nos</a></i></li>
                     <li><a href="contact.php#faq">FAQ</a></i></li>
                  </ul>
               </li>
            </ul>
         </div>

         <ul>
            <li><a href="saved.php">Salvo <i class="far fa-heart"></i></a></li>
            <li><a href="#">Conta <i class="fas fa-angle-down"></i></a>
               <ul>
                  <li><a href="login.php">Conectar-se</a></li>
                  <li><a href="register.php">Registrar nova</a></li>
                  <?php if($user_id != ''){ ?>
                  <li><a href="update.php">Atualizar perfil</a></li>
                  <li><a href="components/user_logout.php" onclick="return confirm('Deseja sair deste website?');">Sair</a>
                  <?php } ?></li>
               </ul>
            </li>
         </ul>
      </section>
   </nav>

</header>

<!-- header section ends -->