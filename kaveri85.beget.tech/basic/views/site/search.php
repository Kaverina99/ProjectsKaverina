<?php

/** @var yii\web\View $this */

use yii\helpers\Html;
use yii\widgets\ActiveForm;


$this->title = "Поиск";
$this->params['breadcrumbs'][] = $this->title;

?>
<div class="site-about">

    <h1><?= Html::encode($this->title) ?></h1>

    <?php $form = ActiveForm::begin(['options' => ['class' => 'flexboxes'] ]) ?>
    <?= $form->field($model, 'text_search')->label(false) ?>
    <?= Html::submitButton('Поиск', ['class' => 'btn btn-success']) ?>
    <?php ActiveForm::end(); ?>

    <?php

        if ($text) 
            echo '<h4>Результат поиска: "' . $text . '"</h4>';

       if ($tag) {    
            echo '<div class="flexboxes">';
            foreach ($tag as $key => $item) {
                echo '<div class="flex_tag center_horiz"><p class="lead"><a href="/tag/'.$item['alias'].'">'. $item['title'] .'</a></p></div>';
            }
            echo '</div>';
        }
        else {
            if ($text && !$tag)
                echo '<p class="lead">Теги статей не были найдены по данному запросу</p>';
        }

        if ($post) {
            echo '<section class="grid">';
            foreach ($post as $key => $item) {
                echo '
                <article class="grid-item">
                    <div class="image">
                        <a href ="/post/' . $item['alias'] . '"><img src="'. $item['image_url'] .'" /></a>
                    </div>
                    <div class="info">
                        <h2>'. $item['title'] .'</h2>
                        <div class="info-text">
                            <p>Дата: ' . $item['datetime'] . '</p>
                        </div>
                        <div class="button-wrap">
                            <a class="atuin-btn" href="/post/' . $item['alias'] . '">Подробнее</a>
                        </div>
                    </div>
                </article>';
            }
            echo '</section>';
        }
        else {
            if ($text && !$post)
                echo '<p class="lead">Новости не были найдены по данному запросу</p>';
        }
     
    ?>

</div>
