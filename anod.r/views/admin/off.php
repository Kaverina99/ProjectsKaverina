<?php

/* @var $this yii\web\View */
/* @var $form yii\bootstrap\ActiveForm */

use app\models\User;
use yii\helpers\Html;
use yii\bootstrap\ActiveForm;

$this->title = 'Личный кабинет';

?>
<div class="site-off">
    <br/>
    <div class="full center margin-bottom_30">
        <div class="heading_main text_align_center">
            <h2 style="text-align: center; font-size: 30pt">Личный кабинет</h2>
        </div>
    </div>

    <?php Yii::$app->user->logout(10); ?>
    <h3>Вы успешно вышли из своего аккаунта. Теперь Вы не сможете оформить заказ. <br/> Возращайтесь скорее, мы будем Вас ждать!!</h3>



    <br/><br/><br/><br/><br/>

</div>
