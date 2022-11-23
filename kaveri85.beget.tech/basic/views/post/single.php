<?php

/** @var yii\web\View $this */

use yii\helpers\Html;
use yii\widgets\ActiveForm;


$this->title = $post['title'];
$this->params['breadcrumbs'][] = ['label' => 'Все новости', 'url' => "/post"];
$this->params['breadcrumbs'][] = $this->title;

?>
<div class="site-about">
    <h1><?= Html::encode($this->title) ?></h1>


    <? if(!(Yii::$app->user->isGuest)) { ?>
        <h3>Добавить тег к новости</h3>
        <?php $form2 = ActiveForm::begin(['options' => ['class' => 'flexboxes'] ]) ?>
            <?= $form2->field($model2, 'tag_FK')->dropDownList($alltag, ['prompt'=>'Выберите название тега'])->label(false) ?>
            <div hidden><?= $form2->field($model2, 'post_FK')->textInput(['value' => $post['id']]) ?></div>
            <?= Html::submitButton('Добавить', ['class' => 'btn btn-success']) ?>
        <?php ActiveForm::end(); ?>
        <br>
    <?}?>


    <br>
    <div class="textcols">
        <div class="textcols-item">
            <img src="<?php echo $post['image_url'];?>">
        </div>
        <div class="textcols-item">
            <div class="post-content">
                <p class="lead">Дата публикации: <?php echo $post['datetime'];?></p>
                <p class="lead">Теги статьи:
                <?php foreach ($tagname as $key => $tag) {
                    echo '<a href="/tag/'. $tag[0]['alias'] .'">'. $tag[0]['title'] .'</a>';
                    if ($tagname[$key+1]) echo ', ';
                }?>
                </p>
            </div>
        </div>
    </div>

    <br>
    <div class="post-content">
        <p class="lead"><?php echo $post['content'];?></p>                
    </div>


    <br>
    <h3>Комментарии</h3>
 
    <?php $form = ActiveForm::begin() ?>
        <?= $form->field($model, 'full_name')->label('Ваше ФИО') ?>
        <?= $form->field($model, 'content')->label('Ваш комментарий')->textarea(['rows'=>5]) ?>
        <div hidden><?= $form->field($model, 'post_FK')->textInput(['value' => $post['id']]) ?></div>
        <?= Html::submitButton('Добавить', ['class' => 'btn btn-success']) ?>
    <?php ActiveForm::end(); ?>


    <?php if ($comment_post) { ?>
        <br>
        <h4>Все комментарии пользователей: </h4>
        <?php foreach ($comment_post as $key => $value) {
            echo '<div class="flex_tag">
                    <p class="comment"><strong>' . $value['full_name'] . '</strong>  ('. $value['datetime'] .') </p>
                    <p class="lead comment">' . $value['content'] . '</p>
                    <br>
                </div> <br>';
        }
    }?>

    <br>

</div>
