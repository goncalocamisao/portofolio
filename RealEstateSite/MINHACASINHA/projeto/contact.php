<?php  
include 'components/connect.php';

if(isset($_COOKIE['user_id'])){
   $user_id = $_COOKIE['user_id'];
}else{
   $user_id = '';
}

if(isset($_POST['send'])){
   $msg_id = create_unique_id();
   $name = $_POST['name'];
   $name = filter_var($name, FILTER_SANITIZE_STRING);
   $email = $_POST['email'];
   $email = filter_var($email, FILTER_SANITIZE_STRING);
   $number = $_POST['number'];
   $number = filter_var($number, FILTER_SANITIZE_STRING);
   $message = $_POST['message'];
   $message = filter_var($message, FILTER_SANITIZE_STRING);

   $verify_contact = $conn->prepare("SELECT * FROM `messages` WHERE name = ? AND email = ? AND number = ? AND message = ?");
   $verify_contact->execute([$name, $email, $number, $message]);

   if($verify_contact->rowCount() > 0){
      $warning_msg[] = 'message sent already!';
   }else{
      $send_message = $conn->prepare("INSERT INTO `messages`(id, name, email, number, message) VALUES(?,?,?,?,?)");
      $send_message->execute([$msg_id, $name, $email, $number, $message]);
      $success_msg[] = 'message send successfully!';
      // Limpar os campos do formulário após o envio
      $_POST = array();
   }

}

?>

<!DOCTYPE html>
<html lang="en">
<head>
   <meta charset="UTF-8">
   <meta http-equiv="X-UA-Compatible" content="IE=edge">
   <meta name="viewport" content="width=device-width, initial-scale=1.0">
   <title>Contacta-nos</title>

   <!-- font awesome cdn link  -->
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.0/css/all.min.css">

   <!-- custom css file link  -->
   <link rel="stylesheet" href="css/style.css">

</head>
<body>
   
<?php include 'components/user_header.php'; ?>

<!-- contact section starts  -->

<section class="contact">

   <div class="row">
      <div class="image">
         <img src="images/contact-img.svg" alt="">
      </div>
      <form action="" method="post">
         <h3>Entrar em contato</h3>
         <!-- Corrigindo os nomes dos campos -->
         <input type="Texto" name="name" required maxlength="50" placeholder="Insira o seu nome" class="box" value="<?php echo isset($_POST['name']) ? $_POST['name'] : ''; ?>">
         <input type="Email" name="email" required maxlength="50" placeholder="Insira o seu email" class="box" value="<?php echo isset($_POST['email']) ? $_POST['email'] : ''; ?>">
         <input type="Número" name="number" required maxlength="10" max="9999999999" min="0" placeholder="Insira o seu número telefónico" class="box" value="<?php echo isset($_POST['number']) ? $_POST['number'] : ''; ?>">
         <textarea name="message" placeholder="Insira a sua mensagem" required maxlength="1000" cols="30" rows="10" class="box"><?php echo isset($_POST['message']) ? $_POST['message'] : ''; ?></textarea>
         <!-- Alterando o tipo do botão para "button" -->
         <input type="button" value="Enviar mensagem" name="send" class="btn" onclick="enviarMensagem()">
      </form>
   </div>

</section>

<!-- contact section ends -->

<!-- faq section starts  -->

<section class="faq" id="faq">

   <h1 class="heading">FAQ</h1>

   <div class="box-container">

      <div class="box">
         <h3>Como posso comprar uma propriedade através da sua empresa?</h3>
         <p>Para comprar uma propriedade conosco, você pode explorar nossas listagens disponíveis em nosso site e entrar em contato conosco para agendar uma visita ou obter mais informações. Nossa equipe dedicada está pronta para ajudá-lo em cada etapa do processo de compra.</p>
      </div>

      <div class="box">
         <h3>Vocês oferecem serviços de aluguel de propriedades?</h3>
         <p>Sim, oferecemos serviços de aluguel de propriedades para uma variedade de opções, incluindo casas, lojas e flats. Você pode explorar as opções disponíveis em nosso site e entrar em contato conosco para obter mais detalhes sobre as propriedades disponíveis para aluguel.</p>
      </div>

      <div class="box">
         <h3>Quais são os benefícios de listar minha propriedade com sua empresa?</h3>
         <p>Listar sua propriedade conosco oferece uma série de benefícios, incluindo exposição a uma ampla base de clientes, suporte profissional durante todo o processo de listagem e venda, e marketing eficaz para garantir que sua propriedade seja vista pelo maior número possível de compradores interessados.</p>
      </div>

      <div class="box">
         <h3>Posso agendar uma visita para ver uma propriedade pessoalmente?</h3>
         <p>Sim, você pode agendar uma visita para ver qualquer uma das propriedades listadas em nosso site. Basta entrar em contato conosco para marcar um horário conveniente, e nossa equipe terá prazer em acompanhá-lo em uma visita pessoal para que você possa conhecer a propriedade em primeira mão.</p>
      </div>

      <div class="box">
         <h3>Como posso saber mais sobre uma propriedade específica listada em seu site?</h3>
         <p>Para obter mais informações sobre qualquer uma das propriedades listadas em nosso site, você pode clicar no link da propriedade para ver detalhes adicionais, incluindo fotos, descrição, preço e detalhes de contato. Além disso, nossa equipe está sempre disponível para responder a quaisquer perguntas que você possa ter ou fornecer informações adicionais, se necessário.</p>
      </div>

   </div>

</section>


<!-- faq section ends -->

<script>
   function enviarMensagem() {
      // Coloque aqui a lógica para enviar a mensagem, se necessário
      alert("Mensagem enviada com sucesso!");
      // Limpar os campos do formulário
      document.getElementsByName("name")[0].value = '';
      document.getElementsByName("email")[0].value = '';
      document.getElementsByName("number")[0].value = '';
      document.getElementsByName("message")[0].value = '';
   }
</script>

<script src="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/2.1.2/sweetalert.min.js"></script>

<?php include 'components/footer.php'; ?>

<!-- custom js file link  -->
<script src="js/script.js"></script>

<?php include 'components/message.php'; ?>

</body>
</html>
