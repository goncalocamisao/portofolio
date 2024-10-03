<?php  

include 'components/connect.php';

if(isset($_COOKIE['user_id'])){
   $user_id = $_COOKIE['user_id'];
}else{
   $user_id = '';
}

?>

<!DOCTYPE html>
<html lang="en">
<head>
   <meta charset="UTF-8">
   <meta http-equiv="X-UA-Compatible" content="IE=edge">
   <meta name="viewport" content="width=device-width, initial-scale=1.0">
   <title>Sobre nós</title>

   <!-- font awesome cdn link  -->
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.0/css/all.min.css">

   <!-- custom css file link  -->
   <link rel="stylesheet" href="css/style.css">

</head>
<body>
   
<?php include 'components/user_header.php'; ?>

<!-- about section starts  -->

<section class="about">

   <div class="row">
      <div class="image">
         <img src="images/about-img.svg" alt="">
      </div>
      <div class="content">
         <h3>Porque escolher-nos?</h3>
         <p>Ao escolher-nos como sua empresa para procurar propriedades de casas, você está optando pela eficiência, confiabilidade e comprometimento com seus objetivos imobiliários. Com uma abordagem centrada no cliente, nossa empresa oferece um serviço personalizado, adaptado às suas necessidades específicas. Nossa equipe de especialistas em imóveis está pronta para fornecer suporte dedicado em cada etapa do processo de busca, garantindo que você encontre a casa dos seus sonhos. Com acesso a uma ampla gama de opções no mercado, tecnologia avançada e um compromisso inabalável com a satisfação do cliente, estamos aqui para tornar sua jornada imobiliária mais fácil e gratificante.</p>
         <a href="contact.php" class="inline-btn">Contatos</a>
      </div>
   </div>

</section>

<!-- about section ends -->

<!-- steps section starts  -->

<section class="steps">

   <h1 class="heading">3 Passos Simples</h1>

   <div class="box-container">

      <div class="box">
         <img src="images/step-1.png" alt="">
         <h3>Procurar Propriedade</h3>
         <p>Encontre a sua próxima casa, loja ou espaço comercial. Explore uma ampla gama de opções disponíveis para compra, aluguel ou investimento. </p>
      </div>

      <div class="box">
         <img src="images/step-2.png" alt="">
         <h3>Contactar Agentes</h3>
         <p>Entre em contato com nossos especialistas imobiliários. Obtenha orientação personalizada e assistência profissional para encontrar a propriedade perfeita para você.</p>
      </div>

      <div class="box">
         <img src="images/step-3.png" alt="">
         <h3>Aproveite a propriedade!</h3>
         <p>Desfrute do seu novo lar ou espaço comercial ao máximo! Estamos aqui para garantir que sua experiência seja memorável e satisfatória.</p>
      </div>

   </div>

</section>

<!-- steps section ends -->

<!-- review section starts  -->

<section class="reviews">

   <h1 class="heading">Análises dos clientes</h1>

   <div class="box-container">

      <div class="box">
         <div class="user">
            <img src="images/pic-1.png" alt="">
            <div>
               <h3>João Pereira</h3>
               <div class="stars">
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star-half-alt"></i>
               </div>
            </div>
         </div>
         <p>Muito obrigado. Tive o prazer de escolher a distinção que acompanha o erro que o leva na hora de descobrir!</p>
      </div>

      <div class="box">
         <div class="user">
            <img src="images/pic-2.png" alt="">
            <div>
               <h3>Ana Gomes</h3>
               <div class="stars">
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star-half-alt"></i>
               </div>
            </div>
         </div>
         <p>
         Excelente serviço! Encontrei minha casa dos sonhos em pouco tempo. Altamente recomendado!</p>
      </div>

      <div class="box">
         <div class="user">
            <img src="images/pic-3.png" alt="">
            <div>
               <h3>Pedro Pires</h3>
               <div class="stars">
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star-half-alt"></i>
               </div>
            </div>
         </div>
         <p>
Ótima equipe de agentes imobiliários. Profissionais e atenciosos. Recomendo</p>
      </div>

      <div class="box">
         <div class="user">
            <img src="images/pic-4.png" alt="">
            <div>
               <h3>Rute Mendes</h3>
               <div class="stars">
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star-half-alt"></i>
               </div>
            </div>
         </div>
         <p>
         Processo de compra fácil e sem complicações. Estou muito satisfeita com minha nova propriedade.</p>
      </div>

      <div class="box">
         <div class="user">
            <img src="images/pic-5.png" alt="">
            <div>
               <h3>Pedro Lima</h3>
               <div class="stars">
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star-half-alt"></i>
               </div>
            </div>
         </div>
         <p>
         Serviço excepcional! Encontrei exatamente o que estava à procura. Muito obrigado!</p>
      </div>

      <div class="box">
         <div class="user">
            <img src="images/pic-6.png" alt="">
            <div>
               <h3>Joana Wing</h3>
               <div class="stars">
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star"></i>
                  <i class="fas fa-star-half-alt"></i>
               </div>
            </div>
         </div>
         <p>Equipe dedicada e prestativa. Fiquei muito feliz com o resultado final. Recomendo a todos!</p>
      </div>

   </div>

</section>

<!-- review section ends -->










<?php include 'components/footer.php'; ?>

<!-- custom js file link  -->
<script src="js/script.js"></script>

</body>
</html>