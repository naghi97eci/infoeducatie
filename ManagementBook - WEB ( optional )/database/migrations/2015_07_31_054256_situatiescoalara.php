<?php

use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class Situatiescoalara extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('Situatiescolara', function (Blueprint $table) {
            $table->increments('ID');
            $table->text('Nume');
            $table->text('Prenume');
            $table->text('Clasa');
            $table->text('Diriginte');
            $table->text('m1');
            $table->text('m2');
            $table->text('m3');
            $table->text('m4');
            $table->text('m5');
            $table->text('m6');
            $table->text('m7');
            $table->text('m8');
            $table->text('m9');
            $table->text('m10');
            $table->text('m11');
            $table->text('m12');
            $table->text('m13');
            $table->text('m14');
            $table->text('m15');
            $table->text('m16');
            $table->text('m17');
            $table->text('m18');
            $table->text('m19');
            $table->text('m20');
            $table->text('m21');
            $table->text('m22');
            $table->text('m23');
            $table->text('m24');
            $table->text('m25');
            $table->text('n1');
            $table->text('n2');
            $table->text('n3');
            $table->text('n4');
            $table->text('n5');
            $table->text('n6');
            $table->text('n7');
            $table->text('n8');
            $table->text('n9');
            $table->text('n10');
            $table->text('n11');
            $table->text('n12');
            $table->text('n13');
            $table->text('n14');
            $table->text('n15');
            $table->text('n16');
            $table->text('n17');
            $table->text('n18');
            $table->text('n19');
            $table->text('n20');
            $table->text('n21');
            $table->text('n22');
            $table->text('n23');
            $table->text('n24');
            $table->text('n25');
            $table->text("Semestrul 1");
            $table->text("Semestrul 2");
            $table->text("Medie Anuala");
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::drop('Situatiescolara');
    }
}
