<?php

/** @var yii\web\View $this */

use yii\helpers\Html;

$this->title = $tag['title'];
$this->params['breadcrumbs'][] = ['label' => 'Теги', 'url' => "/tag"];
$this->params['breadcrumbs'][] = $this->title;

?>
<div class="site-about">
    <h1><?= Html::encode($this->title) ?></h1>

    <div class="post-content">
        <p class="lead"><?php echo $tag['description'];?></p>                
    </div>

    <?php if ($posts[0]) { ?>
        <br>
        <h3>Статьи данной темы</h3>
        <section class="grid">
            <?php foreach ($posts[0] as $key => $post) { ?>
                <article class="grid-item">
                    <div class="image">
                        <a href ="/post/<?=$post['alias']?>"><img src="<?=$post['image_url']?>" /></a>
                    </div>
                    <div class="info">
                        <h2><?=$post['title']?></h2>
                        <div class="info-text">
                            <p>Дата: <?=$post['datetime']?></p>
                        </div>
                        <div class="button-wrap">
                            <a class="atuin-btn" href="/post/<?=$post['alias']?>">Подробнее</a>
                        </div>
                    </div>
                </article>    
            <? } ?>
        </section>
    <? } else { ?>
        <br>
        <h3>В данной теме еще нет опубликованных новостей</h3>
    <? } ?>

   

</div>
