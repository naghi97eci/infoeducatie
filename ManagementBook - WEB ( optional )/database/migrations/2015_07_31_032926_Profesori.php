<?php

use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class Profesori extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('Profesori', function (Blueprint $table) {
            $table->increments('ID');
            $table->text('Nume');
            $table->text('Prenume');
            $table->text('Materie');
            $table->text('Diriginte');
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
        Schema::drop('Profesori');
    }
}
