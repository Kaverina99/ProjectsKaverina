<?php

/** @var yii\web\View $this */

use yii\helpers\Html;
use yii\widgets\ActiveForm;


$this->title = "Все новости";
$this->params['breadcrumbs'][] = $this->title;

?>
<div class="site-about">
    <h1><?= Html::encode($this->title) ?></h1>

    <? if(!(Yii::$app->user->isGuest)) { ?>
        <h3>Добавить новость</h3>
        <?php $form = ActiveForm::begin() ?>
            <?= $form->field($model, 'title')->label('Заголовок') ?>
            <?= $form->field($model, 'content')->label('Текст') ?>
            <?= $form->field($model, 'alias')->label('alias') ?>
            <?= $form->field($model, 'image_url')->label('Ссылка на изображение') ?>
            <?= Html::submitButton('Добавить', ['class' => 'btn btn-success']) ?>
        <?php ActiveForm::end(); ?>
    <?}?>


    <?= app\components\PostsWidget::widget()?>

</div>
