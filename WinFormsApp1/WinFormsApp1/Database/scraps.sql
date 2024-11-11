SET search_path TO public;
CREATE SCHEMA IF NOT EXISTS public;

--
-- Name: admin; Type: TABLE; Schema: public; Owner: postgres
--
CREATE SEQUENCE admin_id_seq START 20240001;
CREATE TABLE public.admin (
    adminid character varying(100) DEFAULT 'ADMIN' || nextval('admin_id_seq'),
    admin_name character varying(25),
    admin_email character varying(25),
    admin_password character varying(25)
);


ALTER TABLE public.admin OWNER TO postgres;

--
-- Name: buyer; Type: TABLE; Schema: public; Owner: postgres
--

CREATE SEQUENCE buyer_id_seq START 20240001;
CREATE TABLE public.buyer (
    buyerid character varying(100) DEFAULT 'BUYER' || nextval('buyer_id_seq'),
    buyer_username character varying(25),
    buyer_email character varying(25),
    buyer_password character varying(25),
    buyer_address character varying(25),
    buyer_phone character varying(25)
);

ALTER TABLE public.buyer OWNER TO postgres;

--
-- Name: buyer_review; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.buyer_review (
    buyerid character varying(100),
    reviewid character varying(100)
);


ALTER TABLE public.buyer_review OWNER TO postgres;

--
-- Name: cart; Type: TABLE; Schema: public; Owner: postgres
--

CREATE SEQUENCE cart_id_seq START 20240001;
CREATE TABLE public.cart (
    cartid character varying(100) DEFAULT 'CART' || nextval('cart_id_seq'),
    buyerid character varying(100),
    productid character varying(100)
);



ALTER TABLE public.cart OWNER TO postgres;

--
-- Name: cart_buyer; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.cart_buyer (
    cartid character varying(100),
    buyerid character varying(100)
);


ALTER TABLE public.cart_buyer OWNER TO postgres;

--
-- Name: category; Type: TABLE; Schema: public; Owner: postgres
--

CREATE SEQUENCE category_id_seq START 20240001;
CREATE TABLE public.category (
    categoryid character varying(100) DEFAULT 'CATEGORY' || nextval('category_id_seq'),
    category_name character varying(25)
);


ALTER TABLE public.category OWNER TO postgres;

--
-- Name: chat; Type: TABLE; Schema: public; Owner: postgres
--

CREATE SEQUENCE chat_id_seq START 20240001;
CREATE TABLE public.chat (
    chatid character varying(100) DEFAULT 'CHAT' || nextval('chat_id_seq'),
    content character varying,
    "timestamp" date,
    sellerid character varying(100),
    buyerid character varying(100)
);


ALTER TABLE public.chat OWNER TO postgres;

--
-- Name: orders; Type: TABLE; Schema: public; Owner: postgres
--

CREATE SEQUENCE orders_id_seq START 20240001;
CREATE TABLE public.orders (
    orderid character varying(100) DEFAULT 'ORDER' || nextval('orders_id_seq'),
    total_price double precision,
    order_status character varying(25),
    buyerid character varying(100),
    productid character varying(100)
);


ALTER TABLE public.orders OWNER TO postgres;

--
-- Name: payment; Type: TABLE; Schema: public; Owner: postgres
--

CREATE SEQUENCE payment_id_seq START 20240001;
CREATE TABLE public.payment (
    paymentid character varying(100) DEFAULT 'PAY' || nextval('payment_id_seq'),
    amount double precision,
    payment_date date,
    payment_method character varying(25),
    orderid character varying(100)
);


ALTER TABLE public.payment OWNER TO postgres;

--
-- Name: product; Type: TABLE; Schema: public; Owner: postgres
--

CREATE SEQUENCE product_id_seq START 20240001;
CREATE TABLE public.product (
    productid character varying(100) DEFAULT 'PROD' || nextval('product_id_seq'),
    product_name character varying(25),
    product_desc character varying(200),
    product_price double precision,
    product_status character varying(25),
    sellerid character varying(100)
);


ALTER TABLE public.product OWNER TO postgres;

--
-- Name: product_cart; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.product_cart (
    cartid character varying(100),
    productid character varying(100)
);


ALTER TABLE public.product_cart OWNER TO postgres;

--
-- Name: product_category; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.product_category (
    productid character varying(100),
    categoryid character varying(100)
);


ALTER TABLE public.product_category OWNER TO postgres;

--
-- Name: product_review; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.product_review (
    productid character varying(100),
    reviewid character varying(100)
);


ALTER TABLE public.product_review OWNER TO postgres;

--
-- Name: review; Type: TABLE; Schema: public; Owner: postgres
--

CREATE SEQUENCE review_id_seq START 20240001;
CREATE TABLE public.review (
    reviewid character varying(100) DEFAULT 'REVIEW' || nextval('review_id_seq'),
    rating integer,
    comment character varying(100),
    review_date date,
    productid character varying(100),
    buyerid character varying(100)
);


ALTER TABLE public.review OWNER TO postgres;

--
-- Name: seller; Type: TABLE; Schema: public; Owner: postgres
--

CREATE SEQUENCE seller_id_seq START 20240001;
CREATE TABLE public.seller (
    sellerid character varying(100) DEFAULT 'SELLER' || nextval('seller_id_seq') ,
    seller_username character varying(25),
    seller_email character varying(25),
    seller_password character varying(25),
    seller_address character varying(25),
    seller_phone character varying(25)
);


ALTER TABLE public.seller OWNER TO postgres;


--
-- Name: admin admin_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.admin
    ADD CONSTRAINT admin_pkey PRIMARY KEY (adminid);


--
-- Name: buyer buyer_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.buyer
    ADD CONSTRAINT buyer_pkey PRIMARY KEY (buyerid);


--
-- Name: cart cart_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cart
    ADD CONSTRAINT cart_pkey PRIMARY KEY (cartid);


--
-- Name: category category_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.category
    ADD CONSTRAINT category_pkey PRIMARY KEY (categoryid);


--
-- Name: chat chat_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.chat
    ADD CONSTRAINT chat_pkey PRIMARY KEY (chatid);


--
-- Name: orders orders_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_pkey PRIMARY KEY (orderid);


--
-- Name: payment payment_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.payment
    ADD CONSTRAINT payment_pkey PRIMARY KEY (paymentid);


--
-- Name: product product_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.product
    ADD CONSTRAINT product_pkey PRIMARY KEY (productid);


--
-- Name: review review_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.review
    ADD CONSTRAINT review_pkey PRIMARY KEY (reviewid);


--
-- Name: seller seller_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.seller
    ADD CONSTRAINT seller_pkey PRIMARY KEY (sellerid);


--
-- Name: buyer_review buyer_review_buyerid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.buyer_review
    ADD CONSTRAINT buyer_review_buyerid_fkey FOREIGN KEY (buyerid) REFERENCES public.buyer(buyerid);


--
-- Name: buyer_review buyer_review_reviewid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.buyer_review
    ADD CONSTRAINT buyer_review_reviewid_fkey FOREIGN KEY (reviewid) REFERENCES public.review(reviewid);


--
-- Name: cart_buyer cart_buyer_buyerid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cart_buyer
    ADD CONSTRAINT cart_buyer_buyerid_fkey FOREIGN KEY (buyerid) REFERENCES public.buyer(buyerid);


--
-- Name: cart_buyer cart_buyer_cartid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cart_buyer
    ADD CONSTRAINT cart_buyer_cartid_fkey FOREIGN KEY (cartid) REFERENCES public.cart(cartid);


--
-- Name: cart cart_buyerid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cart
    ADD CONSTRAINT cart_buyerid_fkey FOREIGN KEY (buyerid) REFERENCES public.buyer(buyerid);


--
-- Name: cart cart_productid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cart
    ADD CONSTRAINT cart_productid_fkey FOREIGN KEY (productid) REFERENCES public.product(productid);


--
-- Name: chat chat_buyerid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.chat
    ADD CONSTRAINT chat_buyerid_fkey FOREIGN KEY (buyerid) REFERENCES public.buyer(buyerid);


--
-- Name: chat chat_sellerid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.chat
    ADD CONSTRAINT chat_sellerid_fkey FOREIGN KEY (sellerid) REFERENCES public.seller(sellerid);


--
-- Name: orders orders_buyerid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_buyerid_fkey FOREIGN KEY (buyerid) REFERENCES public.buyer(buyerid);


--
-- Name: orders orders_productid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_productid_fkey FOREIGN KEY (productid) REFERENCES public.product(productid);


--
-- Name: payment payment_orderid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.payment
    ADD CONSTRAINT payment_orderid_fkey FOREIGN KEY (orderid) REFERENCES public.orders(orderid);


--
-- Name: product_cart product_cart_cartid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.product_cart
    ADD CONSTRAINT product_cart_cartid_fkey FOREIGN KEY (cartid) REFERENCES public.cart(cartid);


--
-- Name: product_cart product_cart_productid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.product_cart
    ADD CONSTRAINT product_cart_productid_fkey FOREIGN KEY (productid) REFERENCES public.product(productid);


--
-- Name: product_category product_category_categoryid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.product_category
    ADD CONSTRAINT product_category_categoryid_fkey FOREIGN KEY (categoryid) REFERENCES public.category(categoryid);


--
-- Name: product_category product_category_productid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.product_category
    ADD CONSTRAINT product_category_productid_fkey FOREIGN KEY (productid) REFERENCES public.product(productid);


--
-- Name: product_review product_review_productid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.product_review
    ADD CONSTRAINT product_review_productid_fkey FOREIGN KEY (productid) REFERENCES public.product(productid);


--
-- Name: product_review product_review_reviewid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.product_review
    ADD CONSTRAINT product_review_reviewid_fkey FOREIGN KEY (reviewid) REFERENCES public.review(reviewid);


--
-- Name: product product_sellerid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.product
    ADD CONSTRAINT product_sellerid_fkey FOREIGN KEY (sellerid) REFERENCES public.seller(sellerid);


--
-- Name: review review_buyerid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.review
    ADD CONSTRAINT review_buyerid_fkey FOREIGN KEY (buyerid) REFERENCES public.buyer(buyerid);


--
-- Name: review review_productid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.review
    ADD CONSTRAINT review_productid_fkey FOREIGN KEY (productid) REFERENCES public.product(productid);


--
-- PostgreSQL database dump complete
--

