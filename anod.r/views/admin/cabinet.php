<?php

/* @var $this yii\web\View */
/* @var $form yii\bootstrap\ActiveForm */

use app\models\User;
use yii\helpers\Html;
use yii\bootstrap\ActiveForm;
use yii\widgets\DetailView;

$this->title = 'Личный кабинет';

?>
<div class="site-about">
    <br/>
    <div class="full center margin-bottom_30">
        <div class="heading_main text_align_center">
            <h2 style="text-align: center; font-size: 30pt">Информация о профиле</h2>
        </div>
    </div>

    <br/>

    <?php
    echo DetailView::widget([
        'model'=>$model,
        'attributes' => [
            'id',
            'surname',
            'name',
            'patronymic',
            'phone',
            'email'
        ]
    ]);

    ?>


    <div class="form-group">
        <a href="/index.php?r=admin/updatecab" class="btn btn-primary">Редактировать</a>
    </div>


    <br/><br/><br/>

</div>
