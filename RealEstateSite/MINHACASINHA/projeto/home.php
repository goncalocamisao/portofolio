<?php  

include 'components/connect.php';

if(isset($_COOKIE['user_id'])){
   $user_id = $_COOKIE['user_id'];
}else{
   $user_id = '';
}

include 'components/save_send.php';

?>

<!DOCTYPE html>
<html lang="en">
<head>
   <meta charset="UTF-8">
   <meta http-equiv="X-UA-Compatible" content="IE=edge">
   <meta name="viewport" content="width=device-width, initial-scale=1.0">
   <title>Home</title>

   <!-- font awesome cdn link  -->
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.0/css/all.min.css">

   <!-- custom css file link  -->
   <link rel="stylesheet" href="css/style.css">

</head>
<body>
   
<?php include 'components/user_header.php'; ?>


<!-- home section starts  -->

<div class="home">

   <section class="center">

      <form action="search.php" method="post">
         <h3>Encontra a tua casa perfeita</h3>
         <div class="box">
            <p>Colocar localização <span>*</span></p>
            <input type="text" name="h_location" required maxlength="100" placeholder="Insira a cidade desejada" class="input">
         </div>
         <div class="flex">
            <div class="box">
               <p>Tipo de propriedade <span>*</span></p>
               <select name="h_type" class="input" required>
                  <option value="flat">Flat</option>
                  <option value="casa">Casa</option>
                  <option value="loja">Loja</option>
               </select>
            </div>
            <div class="box">
               <p>Tipo de oferta <span>*</span></p>
               <select name="h_offer" class="input" required>
                  <option value="venda">Venda</option>
                  <option value="re-vender">Re-vender</option>
                  <option value="arrendar">Arrendar</option>
               </select>
            </div>
            <div class="box">
               <p>Orçamento Mínimo <span>*</span></p>
               <select name="h_min" class="input" required>
                  <option value="5000">5k</option>
                  <option value="10000">10k</option>
                  <option value="15000">15k</option>
                  <option value="20000">20k</option>
                  <option value="30000">30k</option>
                  <option value="40000">40k</option>
                  <option value="50000">50k</option>
                  <option value="100000">100k</option>
                  <option value="500000">500k</option>
                  <option value="1000000">1 Milhão</option>
                  <option value="2000000">2 Milhões</option>
                  <option value="3000000">3 Milhões</option>
                  <option value="4000000">4 Milhões</option>
                  <option value="5000000">5 Milhões</option>
                  <option value="6000000">6 Milhões</option>
                  <option value="7000000">7 Milhões</option>
                  <option value="8000000">8 Milhões</option>
                  <option value="9000000">9 Milhões</option>
                  <option value="10000000">10 Milhões</option>
                  <option value="20000000">20 Milhões</option>
                  <option value="30000000">30 Milhões</option>
                  <option value="40000000">40 Milhões</option>
                  <option value="50000000">50 Milhões</option>
                  <option value="60000000">60 Milhões</option>
                  <option value="70000000">70 Milhões</option>
                  <option value="80000000">80 Milhões</option>
                  <option value="90000000">90 Milhões</option>
                  <option value="100000000">100 Milhões</option>
                  <option value="150000000">150 Milhões</option>
                  <option value="200000000">200 Milhões</option>
               </select>
            </div>
            <div class="box">
               <p>Orçamento Máximo <span>*</span></p>
               <select name="h_max" class="input" required>
                  <option value="5000">5k</option>
                  <option value="10000">10k</option>
                  <option value="15000">15k</option>
                  <option value="20000">20k</option>
                  <option value="30000">30k</option>
                  <option value="40000">40k</option>
                  <option value="50000">50k</option>
                  <option value="100000">100k</option>
                  <option value="500000">500k</option>
                  <option value="1000000">1 Milhão</option>
                  <option value="2000000">2 Milhões</option>
                  <option value="3000000">3 Milhões</option>
                  <option value="4000000">4 Milhões</option>
                  <option value="5000000">5 Milhões</option>
                  <option value="6000000">6 Milhões</option>
                  <option value="7000000">7 Milhões</option>
                  <option value="8000000">8 Milhões</option>
                  <option value="9000000">9 Milhões</option>
                  <option value="10000000">10 Milhões</option>
                  <option value="20000000">20 Milhões</option>
                  <option value="30000000">30 Milhões</option>
                  <option value="40000000">40 Milhões</option>
                  <option value="50000000">50 Milhões</option>
                  <option value="60000000">60 Milhões</option>
                  <option value="70000000">70 Milhões</option>
                  <option value="80000000">80 Milhões</option>
                  <option value="90000000">90 Milhões</option>
                  <option value="100000000">100 Milhões</option>
                  <option value="150000000">150 Milhões</option>
                  <option value="200000000">200 Milhões</option>
               </select>
            </div>
         </div>
         <input type="submit" value="Procurar Propriedade" name="h_search" class="btn">
      </form>

   </section>

</div>

<!-- home section ends -->

<!-- services section starts  -->

<section class="services">

   <h1 class="heading">OS NOSSOS SERVIÇOS</h1>

   <div class="box-container">

      <div class="box">
         <img src="images/icon-1.png" alt="">
         <h3>Comprar Casa</h3>
         <p>Encontre a casa dos seus sonhos em nosso site. Variedade de opções para atender às suas necessidades.</p>
      </div>

      <div class="box">
         <img src="images/icon-2.png" alt="">
         <h3>Arrendar Casa</h3>
         <p>Explore nossa seleção de propriedades disponíveis para aluguel. Encontre o lar perfeito para você, seja a curto ou longo prazo.</p>
      </div>

      <div class="box">
         <img src="images/icon-3.png" alt="">
         <h3>Vender casa</h3>
         <p>Deixe-nos ajudá-lo a vender sua casa. Equipe experiente para facilitar o processo e alcançar os melhores resultados.</p>
      </div>

      <div class="box">
         <img src="images/icon-4.png" alt="">
         <h3>Construções e flats</h3>
         <p>Descubra novas construções e flats disponíveis para compra. Explore projetos modernos e espaçosos.</p>
      </div>

      <div class="box">
         <img src="images/icon-5.png" alt="">
         <h3>Lojas & Centros comerciais</h3>
         <p>Encontre o espaço comercial ideal para o seu negócio. Amplie suas oportunidades de crescimento em nossos lojas e centros comerciais.</p>
      </div>

      <div class="box">
         <img src="images/icon-6.png" alt="">
         <h3>Serviço 24/7</h3>
         <p>Estamos sempre disponíveis para atendê-lo. Suporte contínuo e acesso aos nossos serviços a qualquer hora do dia.</p>
      </div>

   </div>

</section>

<!-- services section ends -->

<!-- listings section starts  -->

<section class="listings">

   <h1 class="heading">Últimas Listagens</h1>

   <div class="box-container">
      <?php
         $total_images = 0;
         $select_properties = $conn->prepare("SELECT * FROM `property` ORDER BY date DESC LIMIT 6");
         $select_properties->execute();
         if($select_properties->rowCount() > 0){
            while($fetch_property = $select_properties->fetch(PDO::FETCH_ASSOC)){
               
            $select_user = $conn->prepare("SELECT * FROM `users` WHERE id = ?");
            $select_user->execute([$fetch_property['user_id']]);
            $fetch_user = $select_user->fetch(PDO::FETCH_ASSOC);

            if(!empty($fetch_property['image_02'])){
               $image_coutn_02 = 1;
            }else{
               $image_coutn_02 = 0;
            }
            if(!empty($fetch_property['image_03'])){
               $image_coutn_03 = 1;
            }else{
               $image_coutn_03 = 0;
            }
            if(!empty($fetch_property['image_04'])){
               $image_coutn_04 = 1;
            }else{
               $image_coutn_04 = 0;
            }
            if(!empty($fetch_property['image_05'])){
               $image_coutn_05 = 1;
            }else{
               $image_coutn_05 = 0;
            }

            $total_images = (1 + $image_coutn_02 + $image_coutn_03 + $image_coutn_04 + $image_coutn_05);

            $select_saved = $conn->prepare("SELECT * FROM `saved` WHERE property_id = ? and user_id = ?");
            $select_saved->execute([$fetch_property['id'], $user_id]);

      ?>
      <form action="" method="POST">
         <div class="box">
            <input type="hidden" name="property_id" value="<?= $fetch_property['id']; ?>">
            <?php
               if($select_saved->rowCount() > 0){
            ?>
            <button type="submit" name="save" class="save"><i class="fas fa-heart"></i><span>saved</span></button>
            <?php
               }else{ 
            ?>
            <button type="submit" name="save" class="save"><i class="far fa-heart"></i><span>save</span></button>
            <?php
               }
            ?>
            <div class="thumb">
               <p class="total-images"><i class="far fa-image"></i><span><?= $total_images; ?></span></p> 
               <img src="uploaded_files/<?= $fetch_property['image_01']; ?>" alt="">
            </div>
            <div class="admin">
               <h3><?= substr($fetch_user['name'], 0, 1); ?></h3>
               <div>
                  <p><?= $fetch_user['name']; ?></p>
                  <span><?= $fetch_property['date']; ?></span>
               </div>
            </div>
         </div>
         <div class="box">
            <div class="price"><i class="fas fa-indian-rupee-sign"></i><span><?= $fetch_property['price']; ?></span></div>
            <h3 class="name"><?= $fetch_property['property_name']; ?></h3>
            <p class="location"><i class="fas fa-map-marker-alt"></i><span><?= $fetch_property['address']; ?></span></p>
            <div class="flex">
               <p><i class="fas fa-house"></i><span><?= $fetch_property['type']; ?></span></p>
               <p><i class="fas fa-tag"></i><span><?= $fetch_property['offer']; ?></span></p>
               <p><i class="fas fa-bed"></i><span><?= $fetch_property['bhk']; ?> BHK</span></p>
               <p><i class="fas fa-trowel"></i><span><?= $fetch_property['status']; ?></span></p>
               <p><i class="fas fa-couch"></i><span><?= $fetch_property['furnished']; ?></span></p>
               <p><i class="fas fa-maximize"></i><span><?= $fetch_property['carpet']; ?>Metros Quadrado/s</span></p>
            </div>
            <div class="flex-btn">
               <a href="view_property.php?get_id=<?= $fetch_property['id']; ?>" class="btn">Ver propriedade</a>
               <input type="submit" value="Enviar Inquérito" name="send" class="btn">
            </div>
         </div>
      </form>
      <?php
         }
      }else{
         echo '<p class="empty">Sem propriedades adicionadas ainda! <a href="post_property.php" style="margin-top:1.5rem;" class="btn"Adicionar nova></a></p>';
      }
      ?>
      
   </div>

   <div style="margin-top: 2rem; text-align:center;">
      <a href="listings.php" class="inline-btn">Ver tudo</a>
   </div>

</section>

<!-- listings section ends -->








<script src="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/2.1.2/sweetalert.min.js"></script>

<?php include 'components/footer.php'; ?>

<!-- custom js file link  -->
<script src="js/script.js"></script>

<?php include 'components/message.php'; ?>

<script>

   let range = document.querySelector("#range");
   range.oninput = () =>{
      document.querySelector('#output').innerHTML = range.value;
   }

</script>

</body>
</html>