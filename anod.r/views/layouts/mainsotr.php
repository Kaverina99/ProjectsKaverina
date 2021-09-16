<?php

/* @var $this \yii\web\View */
/* @var $content string */

use app\models\User;
use app\widgets\Alert;
use yii\helpers\Html;
use yii\bootstrap\Nav;
use yii\bootstrap\NavBar;
use yii\widgets\Breadcrumbs;
use app\assets\AppAsset;

AppAsset::register($this);
?>

<?php $this->beginPage() ?>


<!DOCTYPE html>
<html lang="ru">
<!-- Basic -->
<head>
    <link rel="shortcut icon" href="/images/иконка.png" type="image/png">


    <meta charset="utf-8">

    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <!-- Mobile Metas -->
    <meta name="viewport" content="width=device-width, minimum-scale=1.0, maximum-scale=1.0, user-scalable=no">
    <?php $this->registerCsrfMetaTags() ?>
    <title><?= Html::encode($this->title) ?></title>


    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="css/photo-plus.css">


    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <!-- Pogo Slider CSS -->
    <link rel="stylesheet" href="css/pogo-slider.min.css">
    <!-- Site CSS -->
    <link rel="stylesheet" href="css/style.css">
    <!-- Responsive CSS -->
    <link rel="stylesheet" href="css/responsive.css">
    <!-- Custom CSS -->
    <link rel="stylesheet" href="css/custom.css">


</head>

<body id="home" data-spy="scroll" data-target="#navbar-wd" data-offset="98">

<?php $this->beginBody() ?>



<!-- Start header -->
<header class="top-header">
    <nav class="navbar header-nav navbar-expand-lg">
        <div class="container-fluid">
            <a class="navbar-brand" href="index.php?r=sotrudniki"><img src="/images/logo.gif" alt="image"></a>

            <div class="collapse navbar-collapse justify-content-end" id="navbar-wd">
                <?php

                NavBar::begin();
                echo Nav::widget([
                        'items' => [
                            ['label' => 'О предприятии', 'url' => ['/sotrudniki/index'],
                                'options'=>['class'=>'dropdown'],
                                'items' => [
                                    ['label' => '- Региональные представители', 'url' => ['/sotrudniki/regions']],
                                    ['label' => '- Сервисное обслуживание', 'url' => ['/sotrudniki/servis']],
                                    ['label' => '- Сертификаты', 'url' => ['/sotrudniki/sertif']],
                                    ['label' => '- Патенты', 'url' => ['/sotrudniki/patents']]
                                ]
                            ],
                            ['label' => 'Продукция', 'url' => ['/sotrudniki/product']],
                            ['label' => 'Контакты', 'url' => ['/sotrudniki/contact']],


                            Yii::$app->user->isGuest ? (
                            ['label' => 'Личный кабинет', 'url' => ['/sotrudniki/office']]
                            ) : (
                                '<li>'
                                . Html::beginForm(['/sotrudniki/logout'], 'post')
                                . Html::submitButton(
                                    '' . Yii::$app->user->identity->email . '',
                                    ['class' => 'btn logout']
                                )
                                . Html::endForm()
                                . '</li>'
                            )

                        ]
                    ]
                );

                NavBar::end();
                ?>
            </div>

        </div>
    </nav>
</header>
<!-- End header -->



<div class="container">
    <?= Breadcrumbs::widget([
        'links' => isset($this->params['breadcrumbs']) ? $this->params['breadcrumbs'] : [],
    ]) ?>
    <?= Alert::widget() ?>
    <?= $content ?>
</div>

<!-- Start Footer -->
<footer class="footer-box">
    <div class="container">
        <div class="row">
            <div class="margin-top_30 col-md-8 offset-md-2 white_fonts">
                <div class="row">
                    <div class="col-md-4">
                        <div class="full icon text_align_center">
                            <img src="images/social1.png">
                        </div>
                        <div class="full white_fonts text_align_center">
                            <p> Россия, г.Нижний Новгород
                                <br>ул. Свободы, д. 63
                                <br>По будням с 9:00 до 17:00</p>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="full icon text_align_center">
                            <img src="images/social3.png">
                        </div>
                        <div class="full white_fonts text_align_center">
                            <p>+7(831)233-77-03
                                <br>+7(831)273-01-77</p>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="full icon text_align_center">
                            <img src="images/social2.png">
                        </div>
                        <div class="full white_fonts text_align_center">
                            <p> market@anod.ru </p>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
</footer>
<!-- End Footer -->
<div class="footer_bottom">
    <div class="container">
        <div class="row">
            <div class="col-12">
                <p class="crp">© Научно-производственный центр "АНОД"</p>
                <ul class="bottom_menu">
                    <li><a href = "/index.php?r=sotrudniki/index">Главная</a></li>
                    <li><a href="/index.php?r=sotrudniki/product">Продукция</a></li>
                    <li><a href="/index.php?r=sotrudniki/contact">Контакты</a></li>
                    <li><a href="/index.php?r=sotrudniki/office">Личный кабинет</a></li>
                </ul>
            </div>
        </div>
    </div>
</div>



<a href="#" id="scroll-to-top" class="hvr-radial-out"><i class="fa fa-angle-up"></i></a>

<!-- ALL JS FILES -->
<script src="js/jquery.min.js"></script>
<script src="js/popper.min.js"></script>
<script src="js/bootstrap.min.js"></script>
<!-- ALL PLUGINS -->
<script src="js/jquery.magnific-popup.min.js"></script>
<script src="js/jquery.pogo-slider.min.js"></script>
<script src="js/slider-index.js"></script>
<script src="js/smoothscroll.js"></script>
<script src="js/form-validator.min.js"></script>
<script src="js/contact-form-script.js"></script>
<script src="js/isotope.min.js"></script>
<script src="js/images-loded.min.js"></script>
<script src="js/custom.js"></script>



<?php $this->endBody() ?>
</body>
</html>
<?php $this->endPage() ?>
