<?php

use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class Studenti extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('Studenti', function (Blueprint $table) {
            $table->increments('ID');
            $table->text('Nume');
            $table->text('Prenume');
            $table->text('Clasa');
            $table->text("Data nasterii");
            $table->text('Adresa');
            $table->text("Numar tel:");
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::drop('Studenti');
    }
}
