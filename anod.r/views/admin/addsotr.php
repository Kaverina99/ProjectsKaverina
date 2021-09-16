<?php

/* @var $this yii\web\View */
/* @var $form yii\bootstrap\ActiveForm */
/* @var $model app\models\LoginForm */

use yii\helpers\Html;
use yii\bootstrap\ActiveForm;

$this->title = 'Новый сотрудник';

?>
<div class="site-login">
    <br/>
    <div class="full center margin-bottom_30">
        <div class="heading_main text_align_center">
            <h2 style="text-align: center; font-size: 30pt">Добавление нового сотрудника в систему</h2>
        </div>
    </div>


    <br/>

    <?php $form = ActiveForm::begin(['class'=> 'form-horizontal']); ?>

    <div class="form-row">
        <div class="form-group col-md-6">
            <?= $form->field($model, 'surname')->textInput() ?>
        </div>
        <div class="form-group col-md-6">
            <?= $form->field($model, 'name')->textInput() ?>
        </div>
    </div>

    <div class="form-row">
        <div class="form-group col-md-6">
            <?= $form->field($model, 'patronymic')->textInput() ?>
        </div>
        <div class="form-group col-md-6">
            <?= $form->field($model, 'phone')->textInput() ?>
        </div>
    </div>

    <div class="form-row">
        <div class="form-group col-md-6">
            <?= $form->field($model, 'email')->textInput()?>
        </div>
        <div class="form-group col-md-6">
            <?= $form->field($model, 'password')->passwordInput() ?>
        </div>
    </div>

    <?php $form->field($model, 'roleFK') ?>



    <div>
        <button type="submit" class="btn btn-primary">Подтвердитть</button>
    </div>


    <?php ActiveForm::end(); ?>

    <br/><br/>
</div>
