<?php  

include 'components/connect.php';

if(isset($_COOKIE['user_id'])){
   $user_id = $_COOKIE['user_id'];
}else{
   $user_id = '';
   header('location:login.php');
}

if(isset($_GET['get_id'])){
   $get_id = $_GET['get_id'];
}else{
   $get_id = '';
   header('location:home.php');
}

if(isset($_POST['update'])){

   $update_id = $_POST['property_id'];
   $update_id = filter_var($update_id, FILTER_SANITIZE_STRING);
   $property_name = $_POST['property_name'];
   $property_name = filter_var($property_name, FILTER_SANITIZE_STRING);
   $price = $_POST['price'];
   $price = filter_var($price, FILTER_SANITIZE_STRING);
   $deposite = $_POST['deposite'];
   $deposite = filter_var($deposite, FILTER_SANITIZE_STRING);
   $address = $_POST['address'];
   $address = filter_var($address, FILTER_SANITIZE_STRING);
   $offer = $_POST['offer'];
   $offer = filter_var($offer, FILTER_SANITIZE_STRING);
   $type = $_POST['type'];
   $type = filter_var($type, FILTER_SANITIZE_STRING);
   $status = $_POST['status'];
   $status = filter_var($status, FILTER_SANITIZE_STRING);
   $furnished = $_POST['furnished'];
   $furnished = filter_var($furnished, FILTER_SANITIZE_STRING);
   $bhk = $_POST['bhk'];
   $bhk = filter_var($bhk, FILTER_SANITIZE_STRING);
   $bedroom = $_POST['bedroom'];
   $bedroom = filter_var($bedroom, FILTER_SANITIZE_STRING);
   $bathroom = $_POST['bathroom'];
   $bathroom = filter_var($bathroom, FILTER_SANITIZE_STRING);
   $balcony = $_POST['balcony'];
   $balcony = filter_var($balcony, FILTER_SANITIZE_STRING);
   $carpet = $_POST['carpet'];
   $carpet = filter_var($carpet, FILTER_SANITIZE_STRING); 
   $age = $_POST['age'];
   $age = filter_var($age, FILTER_SANITIZE_STRING);
   $total_floors = $_POST['total_floors'];
   $total_floors = filter_var($total_floors, FILTER_SANITIZE_STRING);
   $room_floor = $_POST['room_floor'];
   $room_floor = filter_var($room_floor, FILTER_SANITIZE_STRING);
   $loan = $_POST['loan'];
   $loan = filter_var($loan, FILTER_SANITIZE_STRING);
   $description = $_POST['description'];
   $description = filter_var($description, FILTER_SANITIZE_STRING);

   if(isset($_POST['lift'])){
      $lift = $_POST['lift'];
      $lift = filter_var($lift, FILTER_SANITIZE_STRING);
   }else{
      $lift = 'no';
   }
   if(isset($_POST['security_guard'])){
      $security_guard = $_POST['security_guard'];
      $security_guard = filter_var($security_guard, FILTER_SANITIZE_STRING);
   }else{
      $security_guard = 'no';
   }
   if(isset($_POST['play_ground'])){
      $play_ground = $_POST['play_ground'];
      $play_ground = filter_var($play_ground, FILTER_SANITIZE_STRING);
   }else{
      $play_ground = 'no';
   }
   if(isset($_POST['garden'])){
      $garden = $_POST['garden'];
      $garden = filter_var($garden, FILTER_SANITIZE_STRING);
   }else{
      $garden = 'no';
   }
   if(isset($_POST['water_supply'])){
      $water_supply = $_POST['water_supply'];
      $water_supply = filter_var($water_supply, FILTER_SANITIZE_STRING);
   }else{
      $water_supply = 'no';
   }
   if(isset($_POST['power_backup'])){
      $power_backup = $_POST['power_backup'];
      $power_backup = filter_var($power_backup, FILTER_SANITIZE_STRING);
   }else{
      $power_backup = 'no';
   }
   if(isset($_POST['parking_area'])){
      $parking_area = $_POST['parking_area'];
      $parking_area = filter_var($parking_area, FILTER_SANITIZE_STRING);
   }else{
      $parking_area = 'no';
   }
   if(isset($_POST['gym'])){
      $gym = $_POST['gym'];
      $gym = filter_var($gym, FILTER_SANITIZE_STRING);
   }else{
      $gym = 'no';
   }
   if(isset($_POST['shopping_mall'])){
      $shopping_mall = $_POST['shopping_mall'];
      $shopping_mall = filter_var($shopping_mall, FILTER_SANITIZE_STRING);
   }else{
      $shopping_mall = 'no';
   }
   if(isset($_POST['hospital'])){
      $hospital = $_POST['hospital'];
      $hospital = filter_var($hospital, FILTER_SANITIZE_STRING);
   }else{
      $hospital = 'no';
   }
   if(isset($_POST['school'])){
      $school = $_POST['school'];
      $school = filter_var($school, FILTER_SANITIZE_STRING);
   }else{
      $school = 'no';
   }
   if(isset($_POST['market_area'])){
      $market_area = $_POST['market_area'];
      $market_area = filter_var($market_area, FILTER_SANITIZE_STRING);
   }else{
      $market_area = 'no';
   }

   $old_image_01 = $_POST['old_image_01'];
   $old_image_01 = filter_var($old_image_01, FILTER_SANITIZE_STRING);
   $image_01 = $_FILES['image_01']['name'];
   $image_01 = filter_var($image_01, FILTER_SANITIZE_STRING);
   $image_01_ext = pathinfo($image_01, PATHINFO_EXTENSION);
   $rename_image_01 = create_unique_id().'.'.$image_01_ext;
   $image_01_tmp_name = $_FILES['image_01']['tmp_name'];
   $image_01_size = $_FILES['image_01']['size'];
   $image_01_folder = 'uploaded_files/'.$rename_image_01;

   if(!empty($image_01)){
      if($image_01_size > 2000000){
         $warning_msg[] = 'image 05 size is too large!';
      }else{
         $update_image_01 = $conn->prepare("UPDATE `property` SET image_01 = ? WHERE id = ?");
         $update_image_01->execute([$rename_image_01, $update_id]);
         move_uploaded_file($image_01_tmp_name, $image_01_folder);
         if($old_image_01 != ''){
            unlink('uploaded_files/'.$old_image_01);
         }
      }
   }

   $old_image_02 = $_POST['old_image_02'];
   $old_image_02 = filter_var($old_image_02, FILTER_SANITIZE_STRING);
   $image_02 = $_FILES['image_02']['name'];
   $image_02 = filter_var($image_02, FILTER_SANITIZE_STRING);
   $image_02_ext = pathinfo($image_02, PATHINFO_EXTENSION);
   $rename_image_02 = create_unique_id().'.'.$image_02_ext;
   $image_02_tmp_name = $_FILES['image_02']['tmp_name'];
   $image_02_size = $_FILES['image_02']['size'];
   $image_02_folder = 'uploaded_files/'.$rename_image_02;

   if(!empty($image_02)){
      if($image_02_size > 2000000){
         $warning_msg[] = 'image 05 size is too large!';
      }else{
         $update_image_02 = $conn->prepare("UPDATE `property` SET image_02 = ? WHERE id = ?");
         $update_image_02->execute([$rename_image_02, $update_id]);
         move_uploaded_file($image_02_tmp_name, $image_02_folder);
         if($old_image_02 != ''){
            unlink('uploaded_files/'.$old_image_02);
         }
      }
   }

   $old_image_03 = $_POST['old_image_03'];
   $old_image_03 = filter_var($old_image_03, FILTER_SANITIZE_STRING);
   $image_03 = $_FILES['image_03']['name'];
   $image_03 = filter_var($image_03, FILTER_SANITIZE_STRING);
   $image_03_ext = pathinfo($image_03, PATHINFO_EXTENSION);
   $rename_image_03 = create_unique_id().'.'.$image_03_ext;
   $image_03_tmp_name = $_FILES['image_03']['tmp_name'];
   $image_03_size = $_FILES['image_03']['size'];
   $image_03_folder = 'uploaded_files/'.$rename_image_03;

   if(!empty($image_03)){
      if($image_03_size > 2000000){
         $warning_msg[] = 'image 05 size is too large!';
      }else{
         $update_image_03 = $conn->prepare("UPDATE `property` SET image_03 = ? WHERE id = ?");
         $update_image_03->execute([$rename_image_03, $update_id]);
         move_uploaded_file($image_03_tmp_name, $image_03_folder);
         if($old_image_03 != ''){
            unlink('uploaded_files/'.$old_image_03);
         }
      }
   }

   $old_image_04 = $_POST['old_image_04'];
   $old_image_04 = filter_var($old_image_04, FILTER_SANITIZE_STRING);
   $image_04 = $_FILES['image_04']['name'];
   $image_04 = filter_var($image_04, FILTER_SANITIZE_STRING);
   $image_04_ext = pathinfo($image_04, PATHINFO_EXTENSION);
   $rename_image_04 = create_unique_id().'.'.$image_04_ext;
   $image_04_tmp_name = $_FILES['image_04']['tmp_name'];
   $image_04_size = $_FILES['image_04']['size'];
   $image_04_folder = 'uploaded_files/'.$rename_image_04;

   if(!empty($image_04)){
      if($image_04_size > 2000000){
         $warning_msg[] = 'image 05 size is too large!';
      }else{
         $update_image_04 = $conn->prepare("UPDATE `property` SET image_04 = ? WHERE id = ?");
         $update_image_04->execute([$rename_image_04, $update_id]);
         move_uploaded_file($image_04_tmp_name, $image_04_folder);
         if($old_image_04 != ''){
            unlink('uploaded_files/'.$old_image_04);
         }
      }
   }

   $old_image_05 = $_POST['old_image_05'];
   $old_image_05 = filter_var($old_image_05, FILTER_SANITIZE_STRING);
   $image_05 = $_FILES['image_05']['name'];
   $image_05 = filter_var($image_05, FILTER_SANITIZE_STRING);
   $image_05_ext = pathinfo($image_05, PATHINFO_EXTENSION);
   $rename_image_05 = create_unique_id().'.'.$image_05_ext;
   $image_05_tmp_name = $_FILES['image_05']['tmp_name'];
   $image_05_size = $_FILES['image_05']['size'];
   $image_05_folder = 'uploaded_files/'.$rename_image_05;

   if(!empty($image_05)){
      if($image_05_size > 2000000){
         $warning_msg[] = 'image 05 size is too large!';
      }else{
         $update_image_05 = $conn->prepare("UPDATE `property` SET image_05 = ? WHERE id = ?");
         $update_image_05->execute([$rename_image_05, $update_id]);
         move_uploaded_file($image_05_tmp_name, $image_05_folder);
         if($old_image_05 != ''){
            unlink('uploaded_files/'.$old_image_05);
         }
      }
   }

   $update_listing = $conn->prepare("UPDATE `property` SET property_name = ?, address = ?, price = ?, type = ?, offer = ?, status = ?, furnished = ?, bhk = ?, deposite = ?, bedroom = ?, bathroom = ?, carpet = ?, age = ?, total_floors = ?, room_floor = ?, loan = ?, lift = ?, security_guard = ?, play_ground = ?, garden = ?, water_supply = ?, power_backup = ?, parking_area = ?, gym = ?, shopping_mall = ?, hospital = ?, school = ?, market_area = ?, description = ? WHERE id = ?");   
   $update_listing->execute([$property_name, $address, $price, $type, $offer, $status, $furnished, $bhk, $deposite, $bedroom, $bathroom, $carpet, $age, $total_floors, $room_floor, $loan, $lift, $security_guard, $play_ground, $garden, $water_supply, $power_backup, $parking_area, $gym, $shopping_mall, $hospital, $school, $market_area, $description, $update_id]);

   $success_msg[] = 'Listagem atualizada com sucesso!';

}

if(isset($_POST['delete_image_02'])){

   $old_image_02 = $_POST['old_image_02'];
   $old_image_02 = filter_var($old_image_02, FILTER_SANITIZE_STRING);
   $update_image_02 = $conn->prepare("UPDATE `property` SET image_02 = ? WHERE id = ?");
   $update_image_02->execute(['', $get_id]);
   if($old_image_02 != ''){
      unlink('uploaded_files/'.$old_image_02);
      $success_msg[] = 'image 02 deleted!';
   }

}

if(isset($_POST['delete_image_03'])){

   $old_image_03 = $_POST['old_image_03'];
   $old_image_03 = filter_var($old_image_03, FILTER_SANITIZE_STRING);
   $update_image_03 = $conn->prepare("UPDATE `property` SET image_03 = ? WHERE id = ?");
   $update_image_03->execute(['', $get_id]);
   if($old_image_03 != ''){
      unlink('uploaded_files/'.$old_image_03);
      $success_msg[] = 'image 03 deleted!';
   }

}

if(isset($_POST['delete_image_04'])){

   $old_image_04 = $_POST['old_image_04'];
   $old_image_04 = filter_var($old_image_04, FILTER_SANITIZE_STRING);
   $update_image_04 = $conn->prepare("UPDATE `property` SET image_04 = ? WHERE id = ?");
   $update_image_04->execute(['', $get_id]);
   if($old_image_04 != ''){
      unlink('uploaded_files/'.$old_image_04);
      $success_msg[] = 'image 04 deleted!';
   }

}

if(isset($_POST['delete_image_05'])){

   $old_image_05 = $_POST['old_image_05'];
   $old_image_05 = filter_var($old_image_05, FILTER_SANITIZE_STRING);
   $update_image_05 = $conn->prepare("UPDATE `property` SET image_05 = ? WHERE id = ?");
   $update_image_05->execute(['', $get_id]);
   if($old_image_05 != ''){
      unlink('uploaded_files/'.$old_image_05);
      $success_msg[] = 'image 05 removida!';
   }

}

?>

<!DOCTYPE html>
<html lang="en">
<head>
   <meta charset="UTF-8">
   <meta http-equiv="X-UA-Compatible" content="IE=edge">
   <meta name="viewport" content="width=device-width, initial-scale=1.0">
   <title>Atualizar propriedade</title>

   <!-- font awesome cdn link  -->
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.0/css/all.min.css">

   <!-- custom css file link  -->
   <link rel="stylesheet" href="css/style.css">

</head>
<body>
   
<?php include 'components/user_header.php'; ?>

<section class="property-form">

   <?php
      $select_properties = $conn->prepare("SELECT * FROM `property` WHERE id = ? ORDER BY date DESC LIMIT 1");
      $select_properties->execute([$get_id]);
      if($select_properties->rowCount() > 0){
         while($fetch_property = $select_properties->fetch(PDO::FETCH_ASSOC)){
         $property_id = $fetch_property['id'];
   ?>
   <form action="" method="POST" enctype="multipart/form-data">
      <input type="hidden" name="property_id" value="<?= $property_id; ?>">
      <input type="hidden" name="old_image_01" value="<?= $fetch_property['image_01']; ?>">
      <input type="hidden" name="old_image_02" value="<?= $fetch_property['image_02']; ?>">
      <input type="hidden" name="old_image_03" value="<?= $fetch_property['image_03']; ?>">
      <input type="hidden" name="old_image_04" value="<?= $fetch_property['image_04']; ?>">
      <input type="hidden" name="old_image_05" value="<?= $fetch_property['image_05']; ?>">
      <h3>Detalhes da propriedade</h3>
      <div class="box">
         <p>Nome da propriedade <span>*</span></p>
         <input type="text" name="property_name" required maxlength="50" placeholder="Insira nome da propriedade" value="<?= $fetch_property['property_name']; ?>" class="input">
      </div>
      <div class="flex">
         <div class="box">
            <p>Preço da propriedade <span>*</span></p>
            <input type="number" name="price" required min="0" max="9999999999" maxlength="10" value="<?= $fetch_property['price']; ?>" placeholder="Insira o preço da propriedade" class="input">
         </div>
         <div class="box">
            <p>Quantia do depósito <span>*</span></p>
            <input type="number" name="deposite" required min="0" max="9999999999" value="<?= $fetch_property['deposite']; ?>" maxlength="10" placeholder="Insira a quantidade do depósito" class="input">
         </div>
         <div class="box">
            <p>Endereço da propriedade <span>*</span></p>
            <input type="text" name="address" required maxlength="100" placeholder="Insira o endereço completo" class="input" value="<?= $fetch_property['address']; ?>">
         </div>
         <div class="box">
            <p>Tipo de propriedade <span>*</span></p>
            <select name="offer" required class="input">
               <option value="<?= $fetch_property['offer']; ?>" selected><?= $fetch_property['offer']; ?></option>
               <option value="Venda">Venda</option>
               <option value="Re-Vender">Re-venda</option>
               <option value="Arrendar">Arrendar</option>
            </select>
         </div>
         <div class="box">
            <p>Tipo de propriedade <span>*</span></p>
            <select name="type" required class="input">
               <option value="<?= $fetch_property['type']; ?>" selected><?= $fetch_property['type']; ?></option>
               <option value="Flat">Flat</option>
               <option value="Casa">Casa</option>
               <option value="Loja">Loja</option>
            </select>
         </div>
         <div class="box">
            <p>Estado da propriedade <span>*</span></p>
            <select name="status" required class="input">
               <option value="<?= $fetch_property['status']; ?>" selected><?= $fetch_property['status']; ?></option>
               <option value="Pronta para se mover">Pronta para se mover</option>
               <option value="Sobre Construção">Sobre construção</option>
            </select>
         </div>
         <div class="box">
            <p>Estado da mobilia <span>*</span></p>
            <select name="furnished" required class="input">
               <option value="<?= $fetch_property['furnished']; ?>" selected><?= $fetch_property['furnished']; ?></option>
               <option value="furnished">Mobiliado</option>
               <option value="semi-furnished">Semi-Mobiliado</option>
               <option value="unfurnished">Não Mobiliado</option>
            </select>
         </div>
         <div class="box">
            <p>Quantos BHK (Quartos, Entradas, Cozinhas) <span>*</span></p>
            <select name="bhk" required class="input">
               <option value="<?= $fetch_property['bhk']; ?>" selected><?= $fetch_property['bhk']; ?> BHK</option>
               <option value="1">1 BHK</option>
               <option value="2">2 BHK</option>
               <option value="3">3 BHK</option>
               <option value="4">4 BHK</option>
               <option value="5">5 BHK</option>
               <option value="6">6 BHK</option>
               <option value="7">7 BHK</option>
               <option value="8">8 BHK</option>
               <option value="9">9 BHK</option>
            </select>
         </div>
         <div class="box">
            <p>Quantos quartos? <span>*</span></p>
            <select name="bedroom" required class="input">
               <option value="<?= $fetch_property['bedroom']; ?>" selected><?= $fetch_property['bedroom']; ?> Quarto</option>
               <option value="0">0 Quartos</option>
               <option value="1">1 Quarto</option>
               <option value="2">2 Quartos</option>
               <option value="3">3 Quartos</option>
               <option value="4">4 Quartos</option>
               <option value="5">5 Quartos</option>
               <option value="6">6 Quartos</option>
               <option value="7">7 Quartos</option>
               <option value="8">8 Quartos</option>
               <option value="9">9 Quartos</option>
            </select>
         </div>
         <div class="box">
            <p>Quantas casas de banho? <span>*</span></p>
            <select name="bathroom" required class="input">
               <option value="<?= $fetch_property['bathroom']; ?>" selected><?= $fetch_property['bathroom']; ?> Casa de banho</option>
               <option value="0">0 Casas de banho</option>
               <option value="1">1 Casa de banho</option>
               <option value="2">2 Casas de banho</option>
               <option value="3">3 Casas de banho</option>
               <option value="4">4 Casas de banho</option>
               <option value="5">5 Casas de banho</option>
               <option value="6">6 Casas de banho</option>
               <option value="7">7 Casas de banho</option>
               <option value="8">8 Casas de banho</option>
               <option value="9">9 Casas de banho</option>
            </select>
         </div>
         <div class="box">
            <p>Quantas varandas? <span>*</span></p>
            <select name="balcony" required class="input">
               <option value="<?= $fetch_property['balcony']; ?>" selected><?= $fetch_property['balcony']; ?> Varanda</option>
               <option value="0">0 Varandas</option>
               <option value="1">1 Varanda</option>
               <option value="2">2 Varandas</option>
               <option value="3">3 Varandas</option>
               <option value="4">4 Varandas</option>
               <option value="5">5 Varandas</option>
               <option value="6">6 Varandas</option>
               <option value="7">7 Varandas</option>
               <option value="8">8 Varandas</option>
               <option value="9">9 Varandas</option>
            </select>
         </div>
         <div class="box">
            <p>Área de tapete <span>*</span></p>
            <input type="number" name="carpet" required min="1" max="9999999999" maxlength="10" placeholder="Quantos metros quadrados?" class="input" value="<?= $fetch_property['carpet']; ?>">
         </div>
         <div class="box">
            <p>Idade da propriedade <span>*</span></p>
            <input type="number" name="age" required min="0" max="99" maxlength="2" placeholder="Qual é a idade da propriedade?" class="input" value="<?= $fetch_property['age']; ?>">
         </div>
         <div class="box">
            <p>Quantia de chãos <span>*</span></p>
            <input type="number" name="total_floors" required min="0" max="99" maxlength="2" placeholder="Quantos andares dísponiveis?" class="input" value="<?= $fetch_property['total_floors']; ?>">
         </div>
         <div class="box">
            <p>Chão do quarto <span>*</span></p>
            <input type="number" name="room_floor" required min="0" max="99" maxlength="2" placeholder="Andar da propriedade" class="input" value="<?= $fetch_property['room_floor']; ?>">
         </div>
         <div class="box">
            <p>Empréstimo <span>*</span></p>
            <select name="loan" required class="input">
               <option value="<?= $fetch_property['loan']; ?>" selected><?= $fetch_property['loan']; ?></option>
               <option value="Disponível">Disponível</option>
               <option value="Não Disponível" >Não Disponível</option>
            </select>
         </div>
      </div>
      <div class="box">
         <p>Descrição da propriedade <span>*</span></p>
         <textarea name="description" maxlength="1000" class="input" required cols="30" rows="10" placeholder="escreva sobre a propriedade..." ><?= $fetch_property['description']; ?></textarea>
      </div>
      <div class="checkbox">
         <div class="box">
            <p><input type="checkbox" name="lift" value="yes" <?php if($fetch_property['lift'] == 'yes'){echo 'checked'; } ?> />Elevadores</p>
            <p><input type="checkbox" name="security_guard" value="yes" <?php if($fetch_property['security_guard'] == 'yes'){echo 'checked'; } ?> />Guarda de segurança</p>
            <p><input type="checkbox" name="play_ground" value="yes" <?php if($fetch_property['play_ground'] == 'yes'){echo 'checked'; } ?> />Parque</p>
            <p><input type="checkbox" name="garden" value="yes" <?php if($fetch_property['garden'] == 'yes'){echo 'checked'; } ?> />Jardim</p>
            <p><input type="checkbox" name="water_supply" value="yes" <?php if($fetch_property['water_supply'] == 'yes'){echo 'checked'; } ?> />Abastecimento de água</p>
            <p><input type="checkbox" name="power_backup" value="yes" <?php if($fetch_property['power_backup'] == 'yes'){echo 'checked'; } ?> />Abastecimento de energia</p>
         </div>
         <div class="box">
            <p><input type="checkbox" name="parking_area" value="yes" <?php if($fetch_property['parking_area'] == 'yes'){echo 'checked'; } ?> />Área de estacionamento</p>
            <p><input type="checkbox" name="gym" value="yes" <?php if($fetch_property['gym'] == 'yes'){echo 'checked'; } ?> />Ginásio</p>
            <p><input type="checkbox" name="shopping_mall" value="yes" <?php if($fetch_property['shopping_mall'] == 'yes'){echo 'checked'; } ?> />Centro comercial</p>
            <p><input type="checkbox" name="hospital" value="yes" <?php if($fetch_property['hospital'] == 'yes'){echo 'checked'; } ?> />Hospital</p>
            <p><input type="checkbox" name="school" value="yes" <?php if($fetch_property['school'] == 'yes'){echo 'checked'; } ?> />Escola</p>
            <p><input type="checkbox" name="market_area" value="yes" <?php if($fetch_property['market_area'] == 'yes'){echo 'checked'; } ?> />Área de mercado</p>
         </div>
      </div>
      <div class="box">
         <img src="uploaded_files/<?= $fetch_property['image_01']; ?>" class="image" alt="">
         <p>Atualizar Imagem 01</p>
         <input type="file" name="image_01" class="input" accept="image/*">
      </div>
      <div class="flex"> 
         <div class="box">
            <?php if(!empty($fetch_property['image_02'])){ ?>
            <img src="uploaded_files/<?= $fetch_property['image_02']; ?>" class="image" alt="">
            <input type="submit" value="remover image 02" name="delete_image_02" class="inline-btn" onclick="return confirm('delete image 02');">
            <?php } ?>
            <p>Atualizar Imagem 02</p>
            <input type="file" name="image_02" class="input" accept="image/*">
         </div>
         <div class="box">
            <?php if(!empty($fetch_property['image_03'])){ ?>
            <img src="uploaded_files/<?= $fetch_property['image_03']; ?>" class="image" alt="">
            <input type="submit" value="remover image 03" name="delete_image_03" class="inline-btn" onclick="return confirm('delete image 03');">
            <?php } ?>
            <p>Atualizar Imagem 03</p>
            <input type="file" name="image_03" class="input" accept="image/*">
         </div>
         <div class="box">
            <?php if(!empty($fetch_property['image_04'])){ ?>
            <img src="uploaded_files/<?= $fetch_property['image_04']; ?>" class="image" alt="">
            <input type="submit" value="remover image 04" name="delete_image_04" class="inline-btn" onclick="return confirm('delete image 04');">
            <?php } ?>
            <p>Atualizar Imagem 04</p>
            <input type="file" name="image_04" class="input" accept="image/*">
         </div>
         <div class="box">
            <?php if(!empty($fetch_property['image_05'])){ ?>
            <img src="uploaded_files/<?= $fetch_property['image_05']; ?>" class="image" alt="">
            <input type="submit" value="remover image 05" name="delete_image_05" class="inline-btn" onclick="return confirm('delete image 05');">
            <?php } ?>
            <p>Atualizar Imagem 05</p>
            <input type="file" name="image_05" class="input" accept="image/*">
         </div>   
      </div>
      <input type="submit" value="Atualizar propriedade" class="btn" name="update">
   </form>
   <?php
      }
   }else{
      echo '<p class="empty">Propriedade não encontrada <a href="post_property.php" style="margin-top:1.5rem;" class="btn">Adicionar nova</a></p>';
   }
   ?>

</section>






<script src="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/2.1.2/sweetalert.min.js"></script>

<?php include 'components/footer.php'; ?>

<!-- custom js file link  -->
<script src="js/script.js"></script>

<?php include 'components/message.php'; ?>

</body>
</html>