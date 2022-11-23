<?php

/** @var yii\web\View $this */

use yii\helpers\Html;

$this->title = 'Новость';
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="site-about">
    <h1><?= Html::encode($this->title) ?></h1>

<?php var_dump($alias); ?>
    <code><?= __FILE__ ?></code>
</div>
