<?php 
namespace app\components;
use yii\base\Widget;

class PostsWidget extends Widget {
	public function run() {
		$posts = \app\models\Posts::find()->select('*')->asArray()->where(['published' => 1])->orderBy(['datetime' => SORT_DESC])->all();

		echo '<section class="grid">';
		
		foreach ($posts as $key => $post) {
			echo '
			    <article class="grid-item">
			        <div class="image">
			            <a href ="/post/' . $post['alias'] . '"><img src="'. $post['image_url'] .'" /></a>
			        </div>
			        <div class="info">
			            <h2>'. $post['title'] .'</h2>
			            <div class="info-text">
			                <p>Дата: ' . $post['datetime'] . '</p>
			            </div>
			            <div class="button-wrap">
			                <a class="atuin-btn" href="/post/' . $post['alias'] . '">Подробнее</a>
			            </div>
			        </div>
			    </article>    
			';
		}

		echo '</section>';
	
	}
}

?>