<?php
require_once('vendor/autoload.php');

$stripe = array(
    "secret_key"      => "sk_test_5Hkzj6j4E7G0PI4BeaVDbhiq",
    "publishable_key" => "pk_test_SEb4PnzBe71HFGxU6jiLlRKZ"
);

\Stripe\Stripe::setApiKey($stripe['secret_key']);
?>