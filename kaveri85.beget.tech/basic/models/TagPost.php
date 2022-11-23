<?php 
namespace app\models;

use yii\db\ActiveRecord;

class TagPost extends ActiveRecord
{

	public static function tableName ()
    {
        return 'tag_post';
    }
}
 

?>